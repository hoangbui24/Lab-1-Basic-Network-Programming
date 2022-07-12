# Lab-1-Basic-Network-Programming
This is just a basic lab which requires some logics and coding syntax with which is aimed to warm-up C# programming

----------------------------

## Task 1: Sum of two decimals (conditon required):
❓ Only enable valid input, write a program which caculates the sum of two decimals and colab it with Winform. <br>
<br>
> Hint: Use MessageBox to show warning if there are invalid inputs.<br>

**Consult interface:**<br>
![image](https://user-images.githubusercontent.com/71567852/173200094-d55f67c0-ddd0-4f5a-a43f-2ad826040532.png)

## Task 2: Max and Min:
❓ Colab with Winform, write a program which finds maximum and minimum numbers in three number imputs. So, the condition is the inputs must be number format. <br>
<br>
> Hint: Use If - else. <br>

**Consult interface:**<br>
![image](https://user-images.githubusercontent.com/71567852/173200370-31b47370-ad99-40ad-a8c1-e465ace16317.png)

## Task 3: Read number:
❓ Write a program colab with winform which reads number from 1 to 9 and displays the text of its number
> Hint: Use Switch-case. <br>

**Consult interface:**<br>
![ảnh](https://user-images.githubusercontent.com/71567852/174531927-c42cd1f1-08ef-4586-a1cc-5470d6c7bf9f.png)

## Task 4: money conversion:
❓Write a simple program to exchange money from 5 common currencies (USD, EUR, GBP, SGD, JPY)
into Vietnam Dong with the following conversion rate: <br>
1 USD = 22,772 VND<br>
1 EUR = 28,132 VND<br>
1 GBP = 31,538 VND<br>
1 SGD = 17,286 VND<br>
1 JPY = 214 VND<br>

**Consult interface:**<br>
![image](https://user-images.githubusercontent.com/71567852/177259334-6f9fc295-8aa6-418a-97a1-f7fc6af39c74.png)

## Task 5: Calculate Sum:
❓Write a program that allows to input 2 integers A and B, calculate and output the result:
- A! and B!
- Sum S<sub>1</sub> = 1+2+3+4+…+A and S<sub>2</sub> = 1+2+3+4+…+B
- Sum S<sub>3</sub> = A<sup>1</sup> + A<sup>2</sup> + A<sup>3</sup> + A<sup>4</sup> + … + A<sup>B</sup>

**Consult interface:**<br>
![image](https://user-images.githubusercontent.com/71567852/178511888-f39a3d3d-8ab4-4115-8aa8-7b8f315ffecc.png)

## Task 6: Array Processing & Aggregation [EXPAND]
❓Write a program that allows inputting a list of student grades as an array of 1 dimension, each point element separated by a comma ",".
For example: 7.5, 5, 8, 10, 9.10, 8.5, 9, 10, 3.5 ,5.5, 2 <br>
** Request: **
- Validity check and message (Entered correct/incorrect format)
- Output a list of grades with subject titles in the format:
   - Subject 1: 7.5 Subject 2: 5 Subject 3: 8 Subject 4: 10 ….
- Perform GPA calculation, display the result.
- Find the student's highest and lowest scores.
- Find the number of subjects passed and failed
- Classify students based on Average Score and constraints:
  - Excellent: Score score >= 8, no subject < 6.5
  - Good: GPA >= 6.5, no subject < 5
  - Average: Average score >=5, no subject < 3.5
  - Weak: GPA >= 3.5, no subject < 2
  - Poor: Remaining
- Customize the interface so that it is beautiful and easy to see

**Consult interface: **<br>
![image](https://user-images.githubusercontent.com/71567852/178513653-30c68a93-1e97-4b76-a94f-9dbd877f42b0.png)

## For easier to navigate, you should create one more form name "Menu":
![image](https://user-images.githubusercontent.com/71567852/178517523-ee199c45-cfb2-4b6a-870b-0b0842e09ee6.png)

Provided that I created a form of Task 1 named "Bai1", here is the code of event button click which navigates to Bai1 form

**Code:**<br>
```
private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }
```







