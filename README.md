ความเป็นมา
  คิดว่าได้ทดสอบตัวเองเป็นเรื่องที่ดีจะได้รู้จักตัวเอง

วัตถุประสงค์ของโปรแกรม
  ทำให้คนที่มีทักษะได้ทดสอบตัวเอง

ครงสร้างของโปรแกรม (Class diagram)

+public Class From1 {
    Authen authen = new Authen();
   -private void Signin_Click(object sender, EventArgs e)
   +string username
   +string password
   +bool status
   -private void Resgiter_Click(object sender, EventArgs e)
   +Resgiter resgiter = new Resgiter();
}
~internal class resgiter {
   +Authen authen = new Authen();
   +public Resgiter()
   -private void button1_Click(object sender, EventArgs e)
   +string Username
   +string Password
   +string IDst
   +string date
   +string Age
   +string Branch
   +bool status
}
~internal class Authen {
   +Authen authen = new Authen();
   -private void AllstdexamToolStripMenuItem_Click(object sender, EventArgs e)
   +string line;
   +string filename
   +try
}
+public partial class Allstd {
   -private void Load_Click(object sender, EventArgs e)
   +string line;
   +string filename
   +try
}

ชื่อของผู้พัฒนาโปรแกรม
นาย นภสินธุ์ ศรีบุรินทร์