namespace MultiStepForm.Services;

public class StepsData
{
    public static readonly string[] Steps = ["YOUR INFO", "SELECT PLAN", "ADD-ONS", "SUMMARY"];
    
    public static readonly (int Id, string Title, decimal Price, string Icon)[] Plans = [
        (1, "Arcade", 9, "/images/icon-arcade.svg"),
        (2, "Advanced", 12, "/images/icon-advanced.svg"),
        (3, "Pro", 15, "/images/icon-pro.svg")
    ];

    public static readonly (string Title, string Description, decimal Price)[] AddOns =
    [
        ("Online service", "Access to multiplayer games", 1),
        ("Larger storage", "Extra 1TB of cloud save", 2),
        ("Customizable profile", "Custom theme on your profile", 2)
    ];
}