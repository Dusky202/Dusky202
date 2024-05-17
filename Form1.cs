using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dusky202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLock.Visible = true;
            SetCircularButton(btnLock);
            SetCircularButton(btnUnlock);
            RoundForm(this);
        }

        private void RoundForm(Form form)
        {
            // Formun yuvarlak köşeleri için bir GraphicsPath oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(0, 0, form.Width, form.Height));

            // Formun Region özelliğini yuvarlak yol ile ayarla
            form.Region = new Region(path);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            btnLock.Visible = false;
            btnUnlock.Visible = true;
            string folderName = "Desktop";
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

            try
            {
                if (Directory.Exists(folderPath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
                    dirInfo.Attributes |= FileAttributes.Hidden | FileAttributes.System;
                    MessageBox.Show("Klasör başarıyla kilitlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirtilen klasör bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Klasöre erişilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Klasöre erişim yetkisi reddedildi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            btnLock.Visible = true;
            btnUnlock.Visible = false;
            string folderName = "Desktop";
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

            try
            {
                if (Directory.Exists(folderPath))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
                    dirInfo.Attributes &= ~(FileAttributes.Hidden | FileAttributes.System);
                    MessageBox.Show("Klasör başarıyla kilidi açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Belirtilen klasör bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Klasöre erişilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Klasöre erişim yetkisi reddedildi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
