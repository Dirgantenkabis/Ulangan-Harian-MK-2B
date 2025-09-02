using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form_Dealer_Motor_Honda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Isi daftar motor Honda di ComboBox
            comboBox1.Items.Add("Honda Beat");
            comboBox1.Items.Add("Honda Scoopy");
            comboBox1.Items.Add("Honda PCX");
            comboBox1.Items.Add("Honda CBR");
            comboBox1.Items.Add("Honda Vario 125");
            comboBox1.Items.Add("Honda Vario 160");

            // Set ComboBox menjadi DropDownList agar tidak bisa diketik
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set default jumlah = 1
            numericUpDown1.Value = 1;
            textBox4.Text = "Rp 0"; // Initialize textBox4
            textBox4.ReadOnly = true; // Make it read-only since it's for display only

            // Daftarkan event handler secara manual (jika tidak terhubung otomatis)
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;

            // Set default selection untuk test
            comboBox1.SelectedIndex = 0; // Honda Beat sebagai default
        }

        private void button1_Click(object sender, EventArgs e) // Hitung
        {
            string nama = textBox1.Text;   // Nama Customer
            string alamat = textBox2.Text; // Alamat
            string hp = textBox3.Text;     // Nomor HP
            string motor = comboBox1.SelectedItem?.ToString();
            int jumlah = (int)numericUpDown1.Value;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(hp) || motor == null)
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi jumlah tidak boleh 0
            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah motor harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Harga motor Honda
            int harga = GetHargaMotor(motor);

            if (harga == 0)
            {
                MessageBox.Show("Harga motor tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int total = harga * jumlah;

            // Update label4 dan textBox4
            textBox4.Text = "Rp " + total.ToString("N0");

            // Force refresh UI
            textBox4.Refresh();

            // Tampilkan struk sederhana
            MessageBox.Show(
                $"===== STRUK PEMBELIAN =====\n\n" +
                $"Nama Customer : {nama}\n" +
                $"Alamat        : {alamat}\n" +
                $"No. HP        : {hp}\n" +
                $"Motor         : {motor}\n" +
                $"Harga Satuan  : Rp {harga:N0}\n" +
                $"Jumlah        : {jumlah}\n" +
                $"Total Harga   : Rp {total:N0}\n\n" +
                $"Terima kasih telah membeli di Dealer Honda!",
                "Struk Pembelian",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Method terpisah untuk mendapatkan harga motor
        private int GetHargaMotor(string motor)
        {
            switch (motor)
            {
                case "Honda Beat": return 17000000;
                case "Honda Scoopy": return 21000000;
                case "Honda PCX": return 32000000;
                case "Honda CBR": return 40000000;
                case "Honda Vario 125": return 22500000;
                case "Honda Vario 160": return 26500000;
                default: return 0;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Clear
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            textBox4.Text = "Rp 0"; // Clear textBox4 as well
        }

        private void button3_Click(object sender, EventArgs e) // Exit
        {
            this.Close();
        }

        // Event handler untuk update otomatis saat motor atau jumlah berubah
        private void UpdateTotalHarga()
        {
            try
            {
                string motor = comboBox1.SelectedItem?.ToString();
                int jumlah = (int)numericUpDown1.Value;

                if (motor != null && jumlah > 0)
                {
                    int harga = GetHargaMotor(motor);
                    if (harga > 0)
                    {
                        int total = harga * jumlah;

                        textBox4.Text = "Rp " + total.ToString("N0");
                    }
                    else
                    {
                        textBox4.Text = "Rp 0";
                    }
                }
                else
                {
                    textBox4.Text = "Rp 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Update total harga secara otomatis saat jumlah berubah
            UpdateTotalHarga();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update total harga secara otomatis saat motor berubah
            UpdateTotalHarga();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // opsional
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // opsional
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // opsional
        }
    }
}