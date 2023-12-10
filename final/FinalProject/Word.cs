using System;
using System.ComponentModel.DataAnnotations;

public abstract class Word
{

    protected int limit;

    protected string tempWord;

    protected string[] words = Array.Empty<string>();
    public abstract string WordList(Random random);

    public abstract string[] Add();

    

}