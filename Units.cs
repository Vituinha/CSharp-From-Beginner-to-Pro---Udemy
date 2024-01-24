namespace Units
{
    public partial class Units : Form
    {
        public Units()
        {
            InitializeComponent();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            this.Icon = MakeIcon();
        }

        private Icon MakeIcon()
        {
            Image img = Properties.Resources.units;


            Bitmap newImg = new Bitmap(img);

            IntPtr Hicon = newImg.GetHicon();
            Icon myIcon = Icon.FromHandle(Hicon);

            return myIcon;

        }
    }
}
