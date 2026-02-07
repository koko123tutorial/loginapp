Latihan LoginApp dengan menggunakan Windows Form App C#
---
Fitur yang di implementasikan:
1. Login
2. Registerasi
3. Dashboard khusus Owner/Admin dan Default
4. Dapat mengubah Role/Password dari akun lain (Owner/Admin Permission)
---
Alat yang digunakan:
1. Visual Studio
2. SQL Server Management Studio
---
Alur Login (Form1):
Input username & password > Check database > If correct & same, do login || else show message "username & password incorrect"

Alur Register (Register):
Input username, password & confirm password > Check if the password criteria are correct > Check if there is same username > if not will upload to database || if there have same username, it will be show message box "Account already registed"

Dashboard (Home):
if role are Owner/Admin, it will show the message box "You're Owner/Admin" and have changes permission to other Accounts || if else role are Default, it will show message box "You're Default" and cannot have changes permission 
