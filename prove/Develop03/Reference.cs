
public class Reference {

    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse) {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = null;
    }
    public Reference(string book, int chapter, int verse, int? endVerse) {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = endVerse;
    }

    public void Display(){
        if(_endVerse == null){
            Console.WriteLine($"{_book} {_chapter}: {_verse}");
            return;
        }
        Console.WriteLine($"{_book} {_chapter}: {_verse}-{_endVerse}");
    }
} 