using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.IO; 


public class GenerateScripture
{
   Dictionary<int, Scripture> _scriptDictionary;

// Accessing individual properties by key:
    private Random _rand;

    public GenerateScripture()
    {
        _rand = new Random();
        _scriptDictionary = new Dictionary<int, Scripture>();

        _scriptDictionary.Add(1, new Scripture{ _book = "1 Nephi", _chapter = 3, _verse = 7, _content = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." });
        _scriptDictionary.Add(2, new Scripture{ _book = "2 Nephi", _chapter = 2, _verse = 27, _content = "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself." });
        _scriptDictionary.Add(3, new Scripture{ _book = "2 Nephi", _chapter = 2, _verse = 8, _verse2 = 9, _content = "8 And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray. 9 But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul." });
        _scriptDictionary.Add(4, new Scripture{ _book = "Mosiah", _chapter = 2, _verse = 17, _content = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God." });
        _scriptDictionary.Add(5, new Scripture{ _book = "Alma", _chapter = 32, _verse = 21, _content = "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true." });
        _scriptDictionary.Add(6, new Scripture{ _book = "Alma", _chapter = 37, _verse = 6,_verse2 = 7, _content = "6 Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. 7 And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls." });
        _scriptDictionary.Add(7, new Scripture{ _book = "Helaman", _chapter = 5, _verse = 12, _content = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall." });
        _scriptDictionary.Add(8, new Scripture{ _book = "Ether", _chapter = 12, _verse = 6, _content = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith." });
        _scriptDictionary.Add(9, new Scripture{ _book = "Ether", _chapter = 12, _verse = 27, _content = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them." });
        _scriptDictionary.Add(10, new Scripture{ _book = "Moroni", _chapter = 10, _verse = 4, _verse2 = 5, _content = "4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things." });


    }

    public (string Reference, string Content) ScriptureGenerate()
    {
        int keyIndex = _rand.Next(1, _scriptDictionary.Count + 1);
        Scripture s = _scriptDictionary[keyIndex];
        string reference;
    
        if (s._verse2 > 0)
            reference = $"{s._book} {s._chapter}:{s._verse}-{s._verse2}";
        else
            reference = $"{s._book} {s._chapter}:{s._verse}";
        
        return (reference, s._content);
        
    }
}