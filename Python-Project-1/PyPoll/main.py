"""
--  Author : Indu   
--  This script analyzes the votes and calculates each of the following:
--  The total number of votes cast
--  A complete list of candidates who received votes
--  The percentage of votes each candidate won
--  The total number of votes each candidate won
--  The winner of the election based on popular vote.
"""

# importing python libraries
import os
import csv
import sys
from collections import Counter

def printFileScreen(ln, filePointer):
    """
    Description : This function will print to a file and stdout
    Arguments: A String , A file Pointer
    Return Value: None
    """
    print(ln)
    filePointer.write(ln+"\n")

def main():
    """
    Description : This is the main function.
    Arguments : None
    Return Value: None
    """
    # Assigning path to the csv data to a variable
    srcfilePath = os.path.join(".","Resources","election_data.csv")
    dstfilePath = os.path.join(".","Resources","election_analysis.txt")

    # Opening the file for reading processing
    totVotes = 0
    candidates = []
    with open(srcfilePath,"r") as f:
        csvreader = csv.reader(f)
        header = next(csvreader,None)
        # Processing the file data for analysis
        
        for index, row in enumerate(csvreader):
            
            totVotes = totVotes + 1         #Calculating the total votes by all candidates
            candidates.append(row[2])

    # Calculating the summary votes for each candidate
    candidateSumm = Counter(candidates)


    # Writing Analysis results to a file and stdout
    with open(dstfilePath, "w") as dstF:
        line1 = f'Election Results'
        line2 = f'--------------------'

        printFileScreen(line1,dstF)

        printFileScreen(line2,dstF)

        line1 = f'Total Votes: {totVotes}'

        printFileScreen(line1,dstF)

        printFileScreen(line2,dstF)

        #Printing the summary details for each candidate
        for k, v in candidateSumm.items():
            line1 = f'{k}: {(v/totVotes*100):.3f}% ({v})'
            printFileScreen(line1,dstF)


        printFileScreen(line2,dstF)
        # Finding the winner
        winner = max(candidateSumm, key=candidateSumm.get)
        line1 = f'Winner: {winner}'

        # Printing the winner
        printFileScreen(line1,dstF)


        printFileScreen(line2,dstF)

if __name__ == main():
    main()
