using System;
using System.Drawing;
using System.Drawing.Printing;
using BaseBackend.classes;

public class CertificatePrinter
{
    private Certificate _certificate;

    public CertificatePrinter(Certificate certificate)
    {
        _certificate = certificate;
    }

    public void Print()
    {
        PrintDocument pd = new PrintDocument();
        pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);

        PrintPreviewDialog preview = new PrintPreviewDialog();
        preview.Document = pd;
        preview.ShowDialog();
    }

    private void PrintPageHandler(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;
        Font titleFont = new Font("Segoe UI", 20, FontStyle.Bold);
        Font textFont = new Font("Segoe UI", 12, FontStyle.Regular);

        g.DrawRectangle(Pens.Black, new Rectangle(50, 50, 700, 900));
        g.DrawString("CERTIFICATE OF ACHIEVEMENT", titleFont, Brushes.DarkBlue, new PointF(100, 100));

        g.DrawString($"Student: {_certificate.StudentId.FullName}", textFont, Brushes.Black, new PointF(100, 200));
        g.DrawString($"Course: {_certificate.CourseId.CourseTitle}", textFont, Brushes.Black, new PointF(100, 250));

        // استاد
        g.DrawString($"Teacher: {_certificate.TeacherName.FullName}", textFont, Brushes.Black, new PointF(100, 300));

        // وضعیت
        g.DrawString($"Status: {_certificate.Status}", textFont, Brushes.Black, new PointF(100, 350));

        // تاریخ
        g.DrawString($"Date: {_certificate.Date.ToString("yyyy/MM/dd")}", textFont, Brushes.Black, new PointF(100, 400));

        // مهر طلایی (نمادین)
        g.FillEllipse(Brushes.Gold, new Rectangle(600, 800, 100, 100));
        g.DrawString("Seal", textFont, Brushes.Black, new PointF(620, 840));
    }
}
