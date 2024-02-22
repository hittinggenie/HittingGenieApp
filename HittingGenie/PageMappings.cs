using System;
namespace HittingGenie
{
	public static class PageMappings
	{
        public static Dictionary<string, Func<Page>> GetMappings()
        {
            return new Dictionary<string, Func<Page>>
            {
                
                { "Pages.VRPHelp.BaseSoftTimingVideo()", () => new Pages.BaseSoftTimingVideo() },
                { "Pages.Mechanics.Coiled()", () => new Pages.Mechanics.Coiled() },
                { "Pages.Mechanics.ArmsLoose()", () => new Pages.Mechanics.ArmsLoose() },
                { "Pages.VRPHelp.EarlyOrLate()", () => new Pages.VRPHelp.EarlyOrLate() },
                { "Pages.VRPHelp.SendToTiming()", () => new Pages.VRPHelp.SendToTiming() },
                { "Pages.Mechanics.FluidMotion()", () => new Pages.Mechanics.FluidMotion() },
                { "Pages.VRPHelp.VRPGuide()", () => new Pages.VRPHelp.VRPGuide() },
                { "MainPage", () => new MainPage() },
                // Add more mappings as needed
            };
        }
    }
}
