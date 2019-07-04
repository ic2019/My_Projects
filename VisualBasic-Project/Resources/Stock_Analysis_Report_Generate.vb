Option Explicit

Sub IterateSheets()
        '*****This sub-routine iterates through all worksheets in the Active workbook.******
         ' Declare Current as a worksheet object variable.
         Dim ws As Worksheet

         ' Loop through all of the worksheets in the active workbook.
         For Each ws In Worksheets
            'Calling Sub Routine to Calculate Stock values
            Call CalculateTickerTotal(ws)
        Next
      End Sub
      
Sub CalculateTickerTotal(ws1 As Worksheet)
'*****This sub-routine performs all processing for each ticker like yearly increase,********
'*****Percentage increase and Total Volume of stock sold etc.********

'Initializing all variables
Dim tickerTotalVolume, lastRow, lastColumn As Long
Dim i, j As Long
Dim tickerName As String
Dim openBal, closeBal As Variant
Dim perChange As Variant


Dim maxTicker As String
Dim maxPer, minPer As Double
Dim minVol, maxVol As LongLong
Dim minPerTicker, maxPerTicker As String

Dim nRow As Integer



'Finding the Last Row and Last column values in each sheet

lastRow = ws1.Cells(Rows.Count, "A").End(xlUp).Row
lastColumn = ws1.Cells(1, Columns.Count).End(xlToLeft).Column

' Clearing the Output range
ws1.Range("I1", "T70924").Clear

'Setting Column header for Ticker Consolidated output
    
    ws1.Cells(1, 9).Value = "Ticker"
    ws1.Cells(1, 10).Value = "Yearly Change"
    ws1.Cells(1, 11).Value = "Percent Change"
    ws1.Cells(1, 12).Value = "Total Stock Volume"
    Range(ws1.Cells(1, 9), ws1.Cells(1, 12)).Font.Bold = True
    Range(ws1.Cells(1, 9), ws1.Cells(1, 12)).Font.Size = 16
        
'Counter to track the row number for printing the consolidated output
j = 2

'Iterating thru the loop to print the Ticker consolidated values
openBal = ws1.Cells(2, 3).Value
tickerName = ws1.Cells(2, 1).Value
For i = 2 To lastRow
    tickerTotalVolume = 0
    'Assigning openBal values to variables
    If i <> 2 Then
        openBal = ws1.Cells(i - 1, 3).Value
        tickerName = ws1.Cells(i - 1, 1).Value
        
    End If
    'Loop to find the total for each ticker
    Do Until tickerName <> ws1.Cells(i, 1)

        closeBal = ws1.Cells(i, 6)
        tickerTotalVolume = tickerTotalVolume + ws1.Cells(i, 7)
        i = i + 1
    Loop
        
        ws1.Cells(j, 9) = tickerName
        
        perChange = closeBal - openBal
        
 
        ws1.Cells(j, 10) = closeBal - openBal
        
        
        'Setting color for yearly change
        If ws1.Cells(j, 10) >= 0 Then
            ws1.Cells(j, 10).Interior.ColorIndex = 4
        Else
            ws1.Cells(j, 10).Interior.ColorIndex = 3
        End If
        
        'Calculating percentage increase
        If openBal = 0 Then
            ws1.Cells(j, 11) = 0
        Else
            ws1.Cells(j, 11) = (closeBal - openBal) / openBal
            
        End If
        
        'Formatting the percent increase column with percent formatting
        'ws1.Cells(j, 11).Style = "Percent"
        ws1.Cells(j, 12) = tickerTotalVolume
        j = j + 1

    

Next i

'Formatting
ws1.Range("I:L").EntireColumn.AutoFit
    
ws1.Range("J:J").EntireColumn.NumberFormat = "0.000000000000000"
ws1.Range("K:K").EntireColumn.NumberFormat = "0.00%"

'Printing the header for Greatest % increase and decrease
ws1.Cells(1, 16).Value = "Ticker"
ws1.Cells(1, 17).Value = "Value"
ws1.Cells(2, 15).Value = "Greatest % Increase"
ws1.Cells(3, 15).Value = "Greatest % Decrease"
ws1.Cells(4, 15).Value = "Greatest Total Volume"
Range(ws1.Cells(1, 15), ws1.Cells(4, 17)).Font.Bold = True
Range(ws1.Cells(1, 15), ws1.Cells(4, 17)).Font.Size = 20


'Finding the last Row for the consolidated outputs for tickers
nRow = ws1.Cells(Rows.Count, "I").End(xlUp).Row

'Printing the Greatest % increase and  Decrease values and formatting


'Calculating max of ticker volume
maxVol = Application.WorksheetFunction.Max(Range(ws1.Cells(2, 12), ws1.Cells(nRow, 12)))

'Finding the ticker for the maximum volume
maxTicker = ws1.Range(ws1.Cells(2, 9), ws1.Cells(nRow, 12)).Find(maxVol).Offset(0, -3)
ws1.Cells(4, 17).Value = maxVol
ws1.Cells(4, 16).Value = maxTicker

'Calculating the maximum percentage increase
maxPer = Application.WorksheetFunction.Max(Range(ws1.Cells(2, 11), ws1.Cells(nRow, 11)))

'Finding the ticker with maximum percentage increase
For i = 2 To nRow
    If ws1.Cells(i, 11).Value = maxPer Then
        maxPerTicker = ws1.Cells(i, 9).Value
        Exit For
        
    End If

Next i


ws1.Cells(2, 17).Value = maxPer
ws1.Cells(2, 16).Value = maxPerTicker

'Calculating minimum percentage decrease for ticker
minPer = Application.WorksheetFunction.Min(Range(ws1.Cells(2, 11), ws1.Cells(nRow, 11)))

'Finding the Ticker name with minimum percentage decrease
For i = 1 To nRow
        If ws1.Cells(i, 11).Value = minPer Then
        minPerTicker = ws1.Cells(i, 9).Value
        Exit For
    End If
Next i

'Formatting cells
ws1.Range("Q2", "Q3").NumberFormat = "0.00%"
ws1.Cells(3, 17).Value = minPer
ws1.Cells(3, 16).Value = minPerTicker

'ws1.Cells(2, 17).Style = "Percent"
'ws1.Cells(3, 17).Style = "Percent"
ws1.Range("O:Q").EntireColumn.AutoFit

End Sub