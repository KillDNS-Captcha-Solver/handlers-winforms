using KillDNS.CaptchaSolver.Core.Captcha;
using KillDNS.CaptchaSolver.Core.Handlers;
using KillDNS.CaptchaSolver.Core.Solutions;
using KillDNS.CaptchaSolver.Handlers.WinForms.UI;
using KillDNS.CaptchaSolver.Handlers.WinForms.Extensions;

namespace KillDNS.CaptchaSolver.Handlers.WinForms.CaptchaHandlers;

public class PictureToTextCaptchaHandler : ICaptchaHandler<PictureCaptcha, TextSolution>
{
    public Task<TextSolution> Handle(PictureCaptcha request, CancellationToken cancellationToken = default)
    {
        PictureToTextCaptchaForm form = new(request.ImageData, cancellationToken);
        form.RunInNewThreadAndWait();
        return Task.FromResult(new TextSolution(form.Answer, form.SolutionResultType));
    }
}