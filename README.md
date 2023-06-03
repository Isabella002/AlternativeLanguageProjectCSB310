# AlternativeLanguageProjectCSB310
Read a CSV file that has statistics for 1000 cell phones.

# REPORT: 

I chose to do this project in C# version c#6 because its not only a well-known object oriented language, but its also a programmiing language that I always wanted to learn for the sake of experience & knowledge. Primarily working with Java & Python for most of my education, I wanted to pick another popular language to put on my resume & also have a project on my GitHub. As I had to learn more about the language for this project, I found it to be true that C# is a powerful programming language. C# supports an abundance of features & functionalities. This is how C# interacts with these concepts:
  
Object-Oriented Programming: C# is a fully object-oriented language, so it supports the principles of abstract data types, inheritance, & polymorphism. In C# programmers can define classes & create objects. 
File Ingestion: C# provides a decent set of classes & methods for file handling as well as ingestion. The "System.IO" namespace has classes like "File" & "StreamReader" that allows the program to read & edit files. In my project, I use File.ReadAllLines() to read the contents of a CSV file.
Conditional Statements: C# also supports conditional statements (if, else if, & switch). These statements will permit the execution of code reliant on specific conditions. Ultimately, conditional statements are most popular for decision-making & branching logic.
Assignment Statements: C# assigns values to variables using assignment statements. The use of the assignment operator "=" to assign a value to a variable (similar to other languages).
Loops: C# provides a variety of loops (for, while, & do-while). 
Subprograms (Functions/Methods): C# also supports creating functions & methods. 
Unit Testing: C# has good support for unit testing & there are various frameworks available (NUnit, MSTest, & xUnit) which include a robust/structured technique when it comes to writing unit tests. In my unit tests they are intended to verify the different methods and functionalities.
Exception Handling: C# has comprehensive exception handling using try-catch to handle those exceptions. 

Libraries that are used: 
System.IO: Contains classes & methods for file input/output operations. It is used to read the contents of the CSV file using the File.ReadAllLines() method.
System.Collections.Generic: Includes a generic collection of classes (List<T>) & is used to store & edit a collection of Cell objects.
System: This is the "core" library in C# that provides fundamental types & functionalities. It is used for general purposes, including exception handling (System.Exception) & basic data types (System.Int32, System.Single, etc.).
I chose to include these libraries in the project because they are part of the standard ".NET Framework" & possess the necessary functionality to handle file operations, collections, & other standard programming tasks. There are a lot of other libraries C# supports that have different reasons for usage. 


To answer the following questions, I had made a PhoneAnalyzer class that answers the questions but it is commented out to run the primary program. 

What company (oem) has the highest average weight of the phone body? 
Motorola

Was there any phones that were announced in one year and released in another? What are they? Give me the oem and models.
OEM: Benefon, Model: Vega
OEM: Haier, Model: V280
OEM: Haier, Model: V190
OEM: Haier, Model: V100
OEM: Haier, Model: P5
OEM: Haier, Model: Z8000
OEM: Kyocera, Model: TG 200
OEM: Lenovo, Model: Yoga Tab 3 10
OEM: LG, Model: B2150
OEM: LG, Model: LG-600
OEM: LG, Model: LG-500
OEM: Maxon, Model: MX-C90
OEM: Maxon, Model: MX-A30
OEM: Maxon, Model: MX-C60
OEM: Maxon, Model: MX-C20
OEM: Maxon, Model: MX-C110
OEM: Maxon, Model: MX-E10
OEM: Maxon, Model: MX-V10
OEM: Maxon, Model: MX-V30
OEM: Maxon, Model: MX-7990
OEM: Maxon, Model: MX-E80
OEM: Maxon, Model: MX-7750
OEM: Maxon, Model: MX-C11
OEM: Maxon, Model: MX-C160
OEM: Maxon, Model: MX-7940
OEM: Maxon, Model: MX-7920
OEM: Maxon, Model: MX-7830
OEM: Maxon, Model: MX-7600
OEM: Maxon, Model: MX-6879
OEM: Maxon, Model: MX-6869
OEM: Maxon, Model: MX-6815
OEM: Maxon, Model: MX-6814
OEM: Mitsubishi, Model: Trium Mondo
OEM: Motorola, Model: A920
OEM: Motorola, Model: A835
OEM: Motorola, Model: T725
OEM: Motorola, Model: V70
OEM: Motorola, Model: C336
OEM: Motorola, Model: C332
OEM: Motorola, Model: C331
OEM: Motorola, Model: Accompli 388
OEM: Motorola, Model: Accompli 008
OEM: Motorola, Model: Timeport 280
OEM: Motorola, Model: V.box(V100)
OEM: Motorola, Model: StarTAC 130
OEM: Motorola, Model: StarTAC 85
OEM: Motorola, Model: StarTAC Rainbow
OEM: Motorola, Model: StarTAC 75+
OEM: Motorola, Model: StarTAC 75
OEM: Motorola, Model: SlimLite
OEM: Motorola, Model: cd930
OEM: Motorola, Model: cd920
OEM: Motorola, Model: M3188
OEM: Motorola, Model: M3288
OEM: Motorola, Model: M3588
OEM: Motorola, Model: M3688
OEM: Motorola, Model: M3788
OEM: Motorola, Model: M3888
OEM: NEC, Model: DB4100
OEM: NEC, Model: G9D+
OEM: O2, Model: XDA II
OEM: O2, Model: Xphone
OEM: O2, Model: XDA
OEM: Panasonic, Model: GD67
OEM: Panasonic, Model: GD75
OEM: Panasonic, Model: GD35
OEM: Panasonic, Model: GD93
OEM: Panasonic, Model: GD30
OEM: Philips, Model: Fisio 625
OEM: Philips, Model: Fisio 620
OEM: Philips, Model: Fisio 610
OEM: Philips, Model: Azalis 268
OEM: Philips, Model: Azalis 238
OEM: Philips, Model: Diga
OEM: Philips, Model: Fizz
OEM: Qtek, Model: 1010
OEM: Sagem, Model: MY G5
OEM: Sagem, Model: MY X-3
OEM: Sagem, Model: MY X-5
OEM: Sagem, Model: MY 3078
OEM: Sagem, Model: MW 3026
OEM: Sagem, Model: MW 3052
OEM: Sagem, Model: MW 3042
OEM: Sagem, Model: MW 3040
OEM: Sagem, Model: MW X1
OEM: Sagem, Model: WA 3050
OEM: Sagem, Model: MW 3020
OEM: Sagem, Model: MC 3000
OEM: Sagem, Model: MC 939 WAP
OEM: Sagem, Model: MC 936
OEM: Sagem, Model: MC 950
OEM: Sagem, Model: MC 959
OEM: Sagem, Model: MC 940
OEM: Sagem, Model: MC 932
OEM: Sagem, Model: RC 922
OEM: Sagem, Model: MC 912
OEM: Sagem, Model: MC 850
OEM: Sagem, Model: MC 825 FM
OEM: Sagem, Model: MC 820
OEM: Sagem, Model: RC 750
OEM: Sagem, Model: RC 730
OEM: Samsung, Model: Q300
OEM: Samsung, Model: Q200
OEM: Samsung, Model: Q100
OEM: Samsung, Model: SGH-250
OEM: Siemens, Model: S55
OEM: Siemens, Model: SX45
OEM: Siemens, Model: SL45i
OEM: Siemens, Model: SL42
OEM: Siemens, Model: SL45
OEM: Siemens, Model: A36
OEM: Siemens, Model: M30
OEM: Siemens, Model: C28
OEM: Sony, Model: CMD J6
OEM: Sony, Model: CMD Z1 plus
OEM: Sony, Model: CMD Z1
OEM: Sony, Model: CM-DX 2000
OEM: Sony, Model: CM-DX 1000
OEM: Tel.Me., Model: T918
OEM: Tel.Me., Model: T919i
OEM: Tel.Me., Model: T919
OEM: Telit, Model: G82
OEM: Telit, Model: GM 882
OEM: Telit, Model: GM 810
OEM: Telit, Model: Estremo
OEM: Telit, Model: GM 710
OEM: Wiko, Model: Sunny2 Plus
OEM: Wiko, Model: Sunny2
OEM: Wiko, Model: Sunny Max
OEM: ZTE, Model: Blade Max View
OEM: Benefon, Model: Vega
OEM: Haier, Model: V280
OEM: Haier, Model: V190
OEM: Haier, Model: V100
OEM: Haier, Model: P5
OEM: Haier, Model: Z8000

How many phones have only one feature sensor? 847

What year had the most phones launched in the 2000s? 2003
