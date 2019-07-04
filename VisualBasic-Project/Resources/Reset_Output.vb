Option Explicit

Sub ResetSheet()
'*****This Sub-routine can be used to clear all the results if required before re-running the report.****
        ' Declare Current as a worksheet object variable.
         Dim ws As Worksheet

         ' Loop through all of the worksheets in the active workbook.
         For Each ws In Worksheets
            'If output range has to be cleared call the below sub routine
            Call ClearData(ws)
         Next
End Sub

Sub ClearData(ws1 As Worksheet)
'Dim ws1 As Worksheet
    'ActiveWorkbook.ActiveSheet.Range(Cells(2, 9), Cells(70924, 12)).ClearFormats
    
    'Clearing the output range
    ws1.Range("I1", "T70924").Clear
    ws1.Range("I1", "T70924").ClearFormats
    'Application.Selection = False

End Sub
