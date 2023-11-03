namespace CalculosGeometricos;

public partial class Form1 : Form
{
    ComboBox cmbFiguras;
    ComboBox cmbCalculos;
    Button btnCalcular;
    TextBox txtResultado;
    Label lblCampo1;
    Label lblCampo2;
    Label lblCampo3;
    TextBox txtCampo1;
    TextBox txtCampo2;
    TextBox txtCampo3;

    public Form1()
    {
        InicializarComponentes();
    }

    public void InicializarComponentes()
    {
        this.Size = new Size(300, 310);//Tamaño de ventana
        //Etiqueta Figura

        Label lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.Location = new Point(13, 15);
        lblFigura.Size = new Size(40, 15);
        this.Controls.Add(lblFigura);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Items.Add("Rombo");
        cmbFiguras.Size = new Size(120, 23);
        cmbFiguras.Location = new Point(13,30);
        this.Controls.Add(cmbFiguras);

        //Etigueta Calculo
        Label lblCalculo = new Label();
        lblCalculo.Text=("Calculo");
        lblCalculo.Size = new Size(50, 15);
        lblCalculo.Location = new Point(151,15);
        this.Controls.Add(lblCalculo);

        //ComboBox Claculo
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Area");
        cmbCalculos.Items.Add("Perimetro");
        cmbCalculos.Size = new Size(120, 23);
        cmbCalculos.Location = new Point(150, 30);
        this.Controls.Add(cmbCalculos);

        //Boton Cacular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(151,165);
        this.Controls.Add(btnCalcular);

        //Label Resultado
        Label lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(15,240);
        this.Controls.Add(lblResultado);

        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 30);
        txtResultado.Location = new Point(80, 240);
        this.Controls.Add(txtResultado);  
        
        //Asignar eventos a Combobox

        cmbFiguras.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
        cmbCalculos.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);

        //Valores de campo genericos
        lblCampo1 = new Label();
        lblCampo2 = new Label();
        lblCampo3 = new Label();
        lblCampo1.Text = "1";
        lblCampo2.Text = "2";
        lblCampo3.Text = "3";
        lblCampo1.AutoSize = true;
        lblCampo2.AutoSize = true;
        lblCampo3.AutoSize = true;
        lblCampo1.Location = new Point(15, 60);
        lblCampo2.Location = new Point(15, 90);
        lblCampo3.Location = new Point(15, 120);
        this.Controls.Add(lblCampo1);
        this.Controls.Add(lblCampo2);
        this.Controls.Add(lblCampo3);

        txtCampo1 = new TextBox();
        txtCampo2 = new TextBox();
        txtCampo3 = new TextBox();
        txtCampo1.Size = new Size(80, 20);
        txtCampo2.Size = new Size(80, 20);
        txtCampo3.Size = new Size(80, 20);
        txtCampo1.Location = new Point(80,60);
        txtCampo2.Location = new Point(80,90);
        txtCampo3.Location = new Point(80,120);
        lblCampo1.Visible = false;
        lblCampo2.Visible = false;
        lblCampo3.Visible = false;
        txtCampo1.Visible = false;
        txtCampo2.Visible = false;
        txtCampo3.Visible = false;
        this.Controls.Add(txtCampo1);
        this.Controls.Add(txtCampo2);
        this.Controls.Add(txtCampo3);

        //eVENTO cLICK AL BOTON
        btnCalcular.Click += new EventHandler(btnCalcular_Click);

    }

    private void cmb_SelectedIndexChanged(object sender , EventArgs e)
    {
        if (this.cmbCalculos.SelectedIndex!=-1&&this.cmbFiguras.SelectedIndex!=1)
        {
            switch (this.cmbFiguras.SelectedItem)
            {
                case "Cuadrado":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        lblCampo1.Text = "Lado1";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Lado1";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    break;
                case "Triangulo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {

                    }
                    else
                    {

                    }

                        break;
            }
        }
    }

    private void btnCalcular_Click(object sender ,EventArgs e)
    {
        if (this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != 1)
        {
            switch (this.cmbFiguras.SelectedItem)
            {
                case "Cuadrado":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        double lado = double.Parse(txtCampo1.Text);
                        double Resultado = 4 * lado;
                        txtResultado.Text = Resultado.ToString();
                    }
                    else
                    {
                        double lado = double.Parse(txtCampo1.Text);
                        double Resultado = lado * lado;
                        txtResultado.Text = Resultado.ToString();
                    }
                    break;
                case "Triangulo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {

                    }
                    else
                    {

                    }

                    break;

            }
        }
    }

}
