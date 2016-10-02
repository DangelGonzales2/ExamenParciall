Public Class MainForm
    Public inicio As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_hombres.Click
        btn_hombres.ForeColor = Color.CadetBlue
        btn_mujeres.ForeColor = Color.DimGray
        btn_calzados.ForeColor = Color.DimGray
        btn_accesorios.ForeColor = Color.DimGray


    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btn_hombres.MouseHover



    End Sub

    Private Sub btn_mujeres_Click(sender As Object, e As EventArgs) Handles btn_mujeres.Click
        btn_hombres.ForeColor = Color.DimGray
        btn_mujeres.ForeColor = Color.CadetBlue
        btn_calzados.ForeColor = Color.DimGray
        btn_accesorios.ForeColor = Color.DimGray
    End Sub

    Private Sub btn_mujeres_MouseHover(sender As Object, e As EventArgs) Handles btn_mujeres.MouseHover

    End Sub

    Private Sub btn_calzados_Click(sender As Object, e As EventArgs) Handles btn_calzados.Click
        btn_hombres.ForeColor = Color.DimGray
        btn_mujeres.ForeColor = Color.DimGray
        btn_calzados.ForeColor = Color.CadetBlue
        btn_accesorios.ForeColor = Color.DimGray
    End Sub

    Private Sub btn_calzados_MouseHover(sender As Object, e As EventArgs) Handles btn_calzados.MouseHover

    End Sub

    Private Sub btn_accesorios_Click(sender As Object, e As EventArgs) Handles btn_accesorios.Click
        btn_hombres.ForeColor = Color.DimGray
        btn_mujeres.ForeColor = Color.DimGray
        btn_calzados.ForeColor = Color.DimGray
        btn_accesorios.ForeColor = Color.CadetBlue
    End Sub

    Private Sub btn_accesorios_MouseHover(sender As Object, e As EventArgs) Handles btn_accesorios.MouseHover

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox5.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-03-normal.jpg")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Cotton Linen V-neck Jumper"
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        inicio += 1
        If (inicio <= 0 Or inicio > 3) Then
            inicio = 1
            lblTitulo.Text = "Cotton Linen V-neck Jumper"
            PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-01-normal.jpg")
            PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-02-normal.jpg")
            PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-03-normal.jpg")
            PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-04-normal.jpg")
        Else
            If (inicio = 1) Then
                lblTitulo.Text = "Cotton Linen V-neck Jumper"
                PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-01-normal.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-02-normal.jpg")
                PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-03-normal.jpg")
                PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-04-normal.jpg")
            ElseIf (inicio = 2) Then
                lblTitulo.Text = "Eng Poplin Shirt"
                lblTitulo.Text = "Cotton Linen V-neck Jumper"
                PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-01-normal.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-02-normal.jpg")
                PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-03-normal.jpg")
                PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-04-normal.jpg")
            ElseIf (inicio = 3) Then
                lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-01-normal.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-02-normal.jpg")
                PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-03-normal.jpg")
                PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-04-normal.jpg")
            End If
        End If
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        inicio -= 1
        If (inicio <= 0 Or inicio > 3) Then
            inicio = 3
            lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
            PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-01-normal.jpg")
            PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-02-normal.jpg")
            PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-03-normal.jpg")
            PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-04-normal.jpg")
        Else
            If (inicio = 1) Then
                lblTitulo.Text = "Cotton Linen V-neck Jumper"
                PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-01-normal.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-02-normal.jpg")
                PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-03-normal.jpg")
                PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-04-normal.jpg")
            ElseIf (inicio = 2) Then
                lblTitulo.Text = "Eng Poplin Shirt"
                PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-01-normal.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-02-normal.jpg")
                PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-03-normal.jpg")
                PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h02\normal\h-02-04-normal.jpg")
            ElseIf (inicio = 3) Then
                lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-01-normal.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-02-normal.jpg")
                PictureBox3.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-03-normal.jpg")
                PictureBox4.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h01\normal\h-01-04-normal.jpg")
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox5.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-01-normal.jpg")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox5.Image = Image.FromFile("C:\Users\Alumno\Desktop\visual162-ep-shoppingcart-start-master\ep-shoppingcart\img\hombres\h03\normal\h-03-02-normal.jpg")

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox5.Image = Image.FromFile(CType(PictureBox4.ImageLocation, String))
    End Sub
End Class