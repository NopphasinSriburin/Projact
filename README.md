ความเป็นมา
```
    คิดว่าได้ทดสอบตัวเองเป็นเรื่องที่ดีจะได้รู้จักตัวเอง
```
วัตถุประสงค์ของโปรแกรม
```
    ทำให้คนที่มีทักษะได้ทดสอบตัวเอง
```
Class Diagram
```mermaid
classDiagram
   class Form{
    +Checkpasswork()
   }
   class Resgiter{
    +String Username
    +String Password
    +String IDst
    +String date
    +String Age
    +String Branch
    -singup()
    -getsingup()
   }
  class Authen{
    -String _username
    -String _password
    -String _ID
    -String Brith
    -String _Age
    -String _Branch
    -Checkpassword()
    +singup()
    +getsingup()
    +Writefile
    +Readfile

  }
  class Insite{
    -Allstdexam()
  }
  class Allstd{
    -Load()
    +openfile
    +DataGitview
  }
  Authen <|-- Resgiter
  Form <|-- Authen
  Insite <|-- Form
  Allstd <|-- Insite

```
ชื่อของผู้พัฒนาโปรแกรม
```
นาย นภสินธุ์ ศรีบุรินทร์
```