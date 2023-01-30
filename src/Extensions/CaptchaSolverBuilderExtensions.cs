using KillDNS.CaptchaSolver.Core.Captcha;
using KillDNS.CaptchaSolver.Core.Handlers;
using KillDNS.CaptchaSolver.Core.Solutions;
using KillDNS.CaptchaSolver.Handlers.WinForms.CaptchaHandlers;

namespace KillDNS.CaptchaSolver.Handlers.WinForms.Extensions;

public static class CaptchaSolverBuilderExtensions
{
    public static IBuilderWithCaptchaHandlers AddWinFormsPictureToTextCaptchaHandler(
        this IBuilderWithCaptchaHandlers builder)
    {
        builder.AddCaptchaHandler<PictureCaptcha, TextSolution, PictureToTextCaptchaHandler>();
        return builder;
    }
}