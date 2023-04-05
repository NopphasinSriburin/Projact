ความเป็นมา
```
คิดว่าได้ทดสอบตัวเองเป็นเรื่องที่ดีจะได้รู้จักตัวเอง
```
วัตถุประสงค์ของโปรแกรม
ทำให้คนที่มีทักษะได้ทดสอบตัวเอง
```
โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown
```
Class diagram
```Mermaid
  class Form1{
    -Checkpassword()
    -Login()
   }
  Resgiter{
    +String Username
    +String Password
    +String IDst
    +String date
    +String Age
    +String Branch
    -Savedata()
  }
  class Authen{
    - String _username
    - String _password
    - String _ID
    - String Brith
    - String _Age
    - String _Branch
    + openfile
    - getusername()
    - getpassword()
    - getID()
    - getBrith()
    - getAge()
    - getBranch()
    - Checkpassword
    - signup
  }
  class Insite{
    +Showdialog Allstd()
  }
  class Allstd{
    +openfile
  }
   Resgiter <|-- Form1
   Authen <|-- Resgiter
   Login <|-- Authen
   Insite <|-- Login
   Allstd <|-- Insite


```
ชื่อของผู้พัฒนาโปรแกรม
```
นาย นภสินธุ์ ศรีบุรินทร์
```