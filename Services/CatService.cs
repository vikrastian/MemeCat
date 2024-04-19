using System.ComponentModel.Design;
using MemeCat.Models;

namespace MemeCat.Services;

public class CatService
{
    public List<CatData> GetCats()
    {
        return new List<CatData>
        {
            new CatData { EmotionTags = new[] { "moody" }, IsGif = false, Image = "./images/angry.jpeg", Alt = "A cat looking moody" },
            new CatData { EmotionTags = new[] { "moody", "insomniac" }, IsGif = false, Image = "./images/angry2.jpeg", Alt = "A cat looking moody" },
            new CatData { EmotionTags = new[] { "moody" }, IsGif = false, Image = "./images/angry3.jpeg", Alt = "A cat looking moody" },
            new CatData { EmotionTags = new[] { "confused", "sad" }, IsGif = false, Image = "./images/confused.jpeg", Alt = "A cat looking confused" },
            new CatData { EmotionTags = new[] { "dominant", "moody" }, IsGif = false, Image = "./images/dominant.jpeg", Alt = "A cat looking dominant" },
            new CatData { EmotionTags = new[] { "happy", "relaxed" }, IsGif = false, Image = "./images/happy.jpeg", Alt = "A cat looking happy" },
            new CatData { EmotionTags = new[] { "hungry" }, IsGif = false, Image = "./images/hungry.jpeg", Alt = "A cat looking hungry" },
            new CatData { EmotionTags = new[] { "hungry" }, IsGif = false, Image = "./images/hungry1.jpeg", Alt = "A cat looking hungry" },
            new CatData { EmotionTags = new[] { "insomniac" }, IsGif = false, Image = "./images/insomnia.jpeg", Alt = "A cat looking insomniac" },
            new CatData { EmotionTags = new[] { "insomniac" }, IsGif = false, Image = "./images/insomnia1.jpeg", Alt = "A cat looking insomniac" },
            new CatData { EmotionTags = new[] { "relaxed" }, IsGif = false, Image = "./images/lazy.jpeg", Alt = "A cat looking lazy" },
            new CatData { EmotionTags = new[] { "scared" }, IsGif = false, Image = "./images/nervous.jpeg", Alt = "A cat looking nervous" },
            new CatData { EmotionTags = new[] { "sad" }, IsGif = false, Image = "./images/sad.jpeg", Alt = "A cat looking sad" },
            new CatData { EmotionTags = new[] { "sad", "moody" }, IsGif = false, Image = "./images/sad1.jpeg", Alt = "A cat looking sad" },
            new CatData { EmotionTags = new[] { "moody" }, IsGif = true, Image = "./images/angry.gif", Alt = "A cat looking moody" },
            new CatData { EmotionTags = new[] { "moody" }, IsGif = true, Image = "./images/angry2.gif", Alt = "A cat looking angry" },
            new CatData { EmotionTags = new[] { "confused" }, IsGif = true, Image = "./images/confused2.gif", Alt = "A cat looking confused" },
            new CatData { EmotionTags = new[] { "dominant" }, IsGif = true, Image = "./images/dominant.gif", Alt = "A cat looking dominant" },
            new CatData { EmotionTags = new[] { "happy" }, IsGif = true, Image = "./images/happy.gif", Alt = "A cat looking happy" },
            new CatData { EmotionTags = new[] { "hungry", "sad", "confused" }, IsGif = true, Image = "./images/confused.gif", Alt = "A cat looking hungry" },
            new CatData { EmotionTags = new[] { "hungry" }, IsGif = true, Image = "./images/hungry.gif", Alt = "A cat looking hungry" },
            new CatData { EmotionTags = new[] { "hungry" }, IsGif = true, Image = "./images/hungry2.gif", Alt = "A cat looking hungry" },
            new CatData { EmotionTags = new[] { "insomniac", "scared" }, IsGif = true, Image = "./images/insomnia2.gif", Alt = "A cat looking insomniac" },
            new CatData { EmotionTags = new[] { "relaxed" }, IsGif = true, Image = "./images/lazy.gif", Alt = "A cat looking relaxed" },
            new CatData { EmotionTags = new[] { "relaxed" }, IsGif = true, Image = "./images/relaxed2.gif", Alt = "A cat looking relaxed" },
            new CatData { EmotionTags = new[] { "scared", "sad" }, IsGif = true, Image = "./images/nervous.gif", Alt = "A cat looking nervous" },
            new CatData { EmotionTags = new[] { "scared" }, IsGif = true, Image = "./images/nervous2.gif", Alt = "A cat looking scared" },
            new CatData { EmotionTags = new[] { "sad" }, IsGif = true, Image = "./images/sad.gif", Alt = "A cat looking sad" }
        };
    }
}