using System;
using System.Collections.Generic;
using System.Linq;

public class RandomizationService
{
    private List<string> characters = new List<string> { "Kääpiö", "Prinsessa", "Ritari", "Velho", "Tyttö" };
    private List<string> weapons = new List<string> { "Hohtava kukka", "Taikasauva", "Miekka", "Kaulin", "Puunuija", "Iso vasara" };

    public List<string> RandomCharacters { get; private set; } = new List<string>();
    public List<string> RandomWeapons { get; private set; } = new List<string>();

    public void GenerateRandomCharacters()
    {
        Random random = new Random();
        RandomCharacters = characters.OrderBy(x => random.Next()).Take(3).ToList();
    }

    public void GenerateRandomWeapons()
    {
        Random random = new Random();
        RandomWeapons = weapons.OrderBy(x => random.Next()).Take(3).ToList();
    }
}