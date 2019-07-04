"""
This script analyses financial data provided in a file budget_data.csv
-- The total number of months included in the dataset
-- The net total amount of "Profit/Losses" over the entire period
-- The average of the changes in "Profit/Losses" over the entire period
-- The greatest increase in profits (date and amount) over the entire period
-- The greatest decrease in losses (date and amount) over the entire period
"""
# importing python libraries
import os
import csv
import sys

def printFileScreen(ln, filePointer):
    """
    Arguments: A String , A file Pointer
    Return Value: None
    """
    print(ln)
    filePointer.write(ln+"\n")

def main():
    """
    Main function
    Arguments : None
    Return Value : NOne
    """

    # Assigning path to the csv data to a variable
    src_filePath = os.path.join(".","Resources","budget_data.csv")
    dst_filePath = os.path.join(".","Resources","budget_analysis.txt")
    changePL = {}
    plDate = []
    # Opening the file for reading processing
    totMonths = 0
    netTotal = 0
    with open(src_filePath,"r") as f:
        csvreader = csv.reader(f)
        header = next(csvreader,None)
        # Processing the file data for analysis

        prevPL = 0   # Initializing previous PL value as 0

        for index,row in enumerate(csvreader):
            # Calculating the total number of months
            totMonths = totMonths + 1
            # Calculating net Profit/Loss
            netTotal = netTotal + int(row[1])
            if index != 0:
                currPL = int(row[1]) # Storing the current P/L value to a variable 

                # Storing increase/decrease of PL in a dictionary list ; Difference between current and previous
                changePL[row[0]] = currPL - prevPL 
                
                prevPL = currPL  # Swapping previous PL value with current
            else:
                prevPL = int(row[1])   # Assigning previous PL with the first ever Profil?Loss value from the file
        #Calculation
        if len(changePL) != 0:
            aveChangePL = round(sum(changePL.values())/len(changePL),2)
        # Writing output to a text file as well as to stdout
        with open(dst_filePath,'w') as dstF:
                line1 = f"-----------------------"
                printFileScreen(line1, dstF)
                
                line1 = f"Financial Analysis"

                printFileScreen(line1, dstF)
                line1 = f"-----------------------"
                printFileScreen(line1, dstF)

                line1 = f'Total Months: {totMonths}'
                printFileScreen(line1,dstF)

                line1 = f'Total: ${netTotal}'
                printFileScreen(line1, dstF)

                line1 = f'Average Change: ${aveChangePL}'
                printFileScreen(line1, dstF)


                # Finding the Greatest Increase and Greatest decrease
                greatestDate = max(changePL, key=changePL.get)
                lowestDate = min(changePL, key=changePL.get)
                line1 = f'Greatest Increase in Profits: {greatestDate} (${changePL[greatestDate]})'

                printFileScreen(line1, dstF)

                line1 = f'Greatest Decrease in Profits: {lowestDate} (${changePL[lowestDate]})'

                printFileScreen(line1, dstF)

if __name__ == main():
    main()
