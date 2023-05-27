
public class Word {

    private string _word;
    private bool _visibility;
    private string _hidden;
    private string hidden;
    private static readonly char[] specialChars = {',','.',';',':','?','!','—','-','\'','"',
                                                   '1','2','3','4','5','6','7','8','9','0', '\n'};

    public Word(string word) {
        this._word = word;
        foreach(char character in _word){
            if(specialChars.Contains(character)){
                hidden += character;
            }
            else {hidden += "_";}
        }
        this._hidden = hidden;
        this._visibility = true;
    }

    public void SetVisibility(bool value){
        _visibility = value;
    }

    public void Display(){
        if(_visibility){
            Console.Write($"{_word} ");
        }
        else if(!_visibility){
            Console.Write($"{_hidden} ");
        }
    }

    public bool GetVisibility(){
        return _visibility;
    }
} 