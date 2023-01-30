using KillDNS.CaptchaSolver.Core.Solutions;
using KillDNS.CaptchaSolver.Handlers.WinForms.Helpers;

namespace KillDNS.CaptchaSolver.Handlers.WinForms.UI;

public partial class PictureToTextCaptchaForm : BaseForm
{
    public string? Answer { get; private set; }
    
    public PictureToTextCaptchaForm(byte[] imageData, CancellationToken cancellationToken = default) : base(cancellationToken)
    {
        InitializeComponent();
        captchaPictureBox.Image = ImageHelper.ByteToImage(imageData);
    }

    private void solutionTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Return)
        {
            Answer = solutionTextBox.Text;
            SolutionResultType = SolutionResultType.Solved;
            Close();
        }
    }
}