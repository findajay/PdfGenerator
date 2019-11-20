# PdfGenerator
<img width="50" height ="50" src="https://dzapk.com/images/2018/10/26/11603/pdf-utility-pdf-tools-v1-2-0-apk_1.jpg?v=1555889274" />

This utility will take empty pdf form for immigration and return the filled pdf form 

## Immigration PDF Form Filler

I have tried to automate task to fill out immigration PDF forms. We can fill out a specific immigration PDF form using data from our database.
I have attached screenshot of JIRA kanban board that i was using to develop this project.

## What and how
This utility is will generate a new version with all its fields filled out on page 1 and page 2.

## Pdf Library 

I am using iText 7 which is a library for creating and manipulating PDF files in Java and .NET. iText was written by Bruno Lowagie. The source code was initially distributed as open source under the Mozilla Public License or the GNU Library General Public License open source licenses.

It was built on nearly a decade of lessons learned from iText 5 (and iTextSharp) development. It is a simpler, more performant and extensible library that is ready to handle the increased challenges of today's document workflows, one add-on at a time.

## How to run :
There are two ways to run this utility either checkout source code from git-hub repository - https://github.com/findajay/PdfGenerator/tree/Development
open it in visual studio and click F5 on system.

OR 
https://drive.google.com/file/d/1FwNJSCnlFtH6qSQvbbHTEVMkFLm5ef0z/view?usp=sharing
Download exe installer for this utility from url above, this can be installed on any machine. Just extract the zip file and click on setup inside it.

## There are two input files :

1. Source file (Upload blank immigration form pdf from your system drive) 
2. Output file (Create a copy of same blank immigration form pdf from your system drive and upload it into output pdf) This will be the output file after filling form. 

## Output:
The same PDF which you selected in Ouput file with some data filled in on page 1 and page 2

## Development Tools used while developing 
1. Visual Studio 2019 
2. JIRA for canban board and stories 
3. Visual Studio code 


