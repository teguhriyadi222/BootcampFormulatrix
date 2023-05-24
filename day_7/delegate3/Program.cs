

delegate string TextTranslator(string text);

class Translator
{
    public string TranslateToIndonesian(string text)
    {
        return "terjemahan ke indonesia " + text;
    }

    public string TranslateTojapanese(string text){

        return "terjemahan ke japanese " + text;
    }

    public string TranslateToSpanish(string text){

        return "terjemahan ke spanish " + text;
    }
}

class program {
    static void Main()
    {
        Translator translator = new Translator();

        TextTranslator translateTextDelegate = translator.TranslateToIndonesian;
        translateTextDelegate += translator.TranslateTojapanese;
        translateTextDelegate += translator.TranslateToSpanish;

        string text = "hello world";
        string translated = translateTextDelegate(text);
        Console.WriteLine(translated);
    }
}