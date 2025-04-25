---
title: Lab 02 java
revision:
    "2024-11-15": "(A, mos) First version, refactored from C#."
---
Lab 02: Conditions and iterations
===========================

In this laboration you get to practice the basics of Java with conditions and iterations. You will practice conditions using if, else if, else , switch and iterations with for, while and do-while.

You may need to look up some things like built-in methods for `Object.valueOf()` and `Object.toString()`.

[[_TOC_]]



Precondition
---------------------------

You have installed Java and you are aware of the basics in writing expressions and statements in Java.

You know the basics of conditions and iterations.



Prepare
---------------------------

Carry out the following steps to create the files needed for the lab.



### Create the directory to work in

Move to the directory where you want to work. Then create the following directory structure.

```bash
cd lab

mkdir lab_02
cd lab_02
ls
```

The directory should be empty and you can now download the files for the lab.



### Get the files for the lab

You need to download a couple of files. Do it using the following commands in the terminal of your choice.

<details>
<summary>Download using Windows PowerShell terminal</summary>

```bash
$LAB_URL="https://gitlab.com/mikael-roos/java/-/raw/main/lab/lab_02"
wget -OutFile Main.java $LAB_URL/Main.java
wget -OutFile Lab.java $LAB_URL/Lab.java
wget -OutFile Answer.java $LAB_URL/Answer.java
```

When you are ready it might look like this.

```bash
PS C:\Users\mos\lab\lab_02> ls

    Directory: C:\Users\mos\lab\lab_02

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a----        11/11/2024   2:42 PM           4736 Answer.java
-a----        11/11/2024   2:42 PM           7983 Lab.java
-a----        11/11/2024   2:42 PM           6139 Main.java
```

</details>

<details>
<summary>Download using Bash terminal</summary>

```bash
export LAB_URL="https://gitlab.com/mikael-roos/java/-/raw/main/lab/lab_02"
wget -O Main.java $LAB_URL/Main.java
wget -O Lab.java $LAB_URL/Lab.java
wget -O Answer.java $LAB_URL/Answer.java
```

When you are ready it might look like this.

```bash
$ ls -l 
total 24K
-rw-rw-r-- 1 mos mos 4,7K nov 10 23:21 Answer.java
-rw-rw-r-- 1 mos mos 7,8K nov 10 23:21 Lab.java
-rw-rw-r-- 1 mos mos 6,1K nov 10 23:21 Main.java
```

</details>

<details>
<summary>Download using Mac terminal with curl</summary>

```bash
export LAB_URL="https://gitlab.com/mikael-roos/java/-/raw/main/lab/lab_02"
curl --output Main.java $LAB_URL/Main.java
curl --output Lab.java $LAB_URL/Lab.java
curl --output Answer.java $LAB_URL/Answer.java
```

When you are ready it might look like this.

```bash
$ ls -l 
total 24K
-rw-rw-r-- 1 mos mos 4,7K nov 10 23:21 Answer.java
-rw-rw-r-- 1 mos mos 7,8K nov 10 23:21 Lab.java
-rw-rw-r-- 1 mos mos 6,1K nov 10 23:21 Main.java
```

</details>

You can now open your vscode from this dicetory.

```
code .
```

Look around in the files from the lab and try to understand how they connect to each other and what they contain.



Begin with the lab
---------------------------

You can compile and execute the lab with the following command.

<details>
<summary>Compile and execute in Windows PowerShell terminal</summary>

If you are on an older version of PowerShell (pre 7), then you need to compile and execute like this.

```bash
javac *.java; java Main
```

On newer versions of PowerShell you can compile all Java files `*.java` and if it is successful execute the main program.

```bash
javac *.java && java Main
```

**HINT 1: smileys** Set the environment variable to ensure the UTF-8 characters are displayed. You only do this once for each terminal you start up.

```powershell
$Env:JAVA_TOOL_OPTIONS="-Dfile.encoding=UTF8"
```

**HINT 2: smileys** Enable PowerShell UTF-8 support. If you can not see the UTF-8 characters and smileys, then try to "[Enable UTF-8 support in Windows PowerShell to print emojis from (Java) code](https://gitlab.com/mikael-roos/java/-/issues/1)".

</details>

<details>
<summary>Compile and execute in Bash terminal</summary>

Compile all Java files `*.java` and if it is successful execute the main program.

```bash
javac *.java && java Main
```

</details>

It can look something like this.

```bash
❌ 1p. hello(), expected: "Hello World!" (java.lang.String), actual: "" (java.lang.String)
... more output 
 --------------------------------------------------------------------
| Total: 42, Passed ✅: 0, Failed ❌: 42
|
| Points needed to PASS=15, PASS WITH HONOUR=19, TOTAL=21
|  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  ⦾  😁  ⦾  ⦾  ⦾  😍  ⦾  🙌 
|
| You have 0 points. Try to earn 1 point to get started... 😏
 --------------------------------------------------------------------
```

The main program is in `Main.java` and it executes the methods in `Answer.java` using the lab tools in `Lab.java`.

You are supposed to implement the bodies of the methods in `Answer.java`.


<!--
The first method
---------------------------

In the first method in `Answer.java` you should implement the following method.

```java
/**
 * Return the string "Hello World!".
 */
public static String hello()
{
    // TODO: Write your code here.
    return "";
}
```

When you are done with your implementation, compile and execute the code again to see if you solved it correctly.

```bash
$ javac *.java && java Main                                                                              
✅ 1p. hello(), expected: "Hello World!" (java.lang.String), actual: "Hello World!" (java.lang.String)   
```

Click on "Solution" below to see how the method should look like when you have implemented it.

<details>
<summary>Solution to the first method</summary>

```java
/**
    * Return the string "Hello World!".
    */
public static String hello()
{
    // TODO: Write your code here.
    return "Hello World!";
}
```

</details>

Now continue with the next method, and then the next method, until you are done.

-->

Get help
---------------------------

You may use any helper tool to get information about how to solve the methods in the lab, but you should always write and own your own code.

Do not plain copy code without understanding what the code does. Its rather a waste of time to work through this lab if you copy someone else solution. Always make the code "your own".
 


Solution
---------------------------

This lab has a solution in [`Solution.java`](https://gitlab.com/mikael-roos/java/-/blob/main/lab/lab_02/Solution.java) which you can review online. Use it as a help and learning tool. Do not simply copy it, that is just a waste of your invested learning time.
