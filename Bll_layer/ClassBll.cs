using Dal;
using DTO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Bll
{

    public class ClassBll
    {
        public List<SearchResult> TanachSearchWord(string word)
        {
            List<SearchResult> resultList = new List<SearchResult>();
            string book = null;
            string parasha = null;
            string chapter = null;
            string verse = null;
            ClassDal cd= new ClassDal();
            string tanachText = cd.GetTanachText();
            string [] lines = tanachText.Split('\n');
            for(int line=0; line< lines.Length; line++)
            {
                string [] words= lines[line].Split(" ");
                for(int word1=0; word1<words.Length; word1++) 
                {
                    if (words[word1].Contains('^')) 
                    {
                        int start=word1+1; 
                        parasha =string.Join(" ", words.Skip(start)).Trim(); 
                    }
                    else if(words[word1].Contains('~'))
                    {
                        book= words[word1 + 1].Trim() ;  
                        chapter = words[word1 + 2].Trim();
                    }
                    else if(words[word1].Contains('!'))
                    {
                        verse = words[word1 + 1].Trim() ;
                    }
                    if (words[word1] == word)
                    {
                        resultList.Add(new SearchResult( book,parasha, chapter,verse));
                    }
                }
            }
            return resultList;
        }
        public List<string> SesrchNumber(int number)
            {
            ClassDal cd = new ClassDal();

            string[][] strDictNum=cd.ReadNumDictJSONFile();
            char[] letters = { 'מ', 'ו', 'ש', 'ה', 'כ', 'ל', 'ב' };
            List<string> listToSearch = new List<string>();
            List<string> resultList= new List<string>();

            foreach(string strNum in strDictNum[number])
            {
                listToSearch.Add(strNum);
                foreach(char c in letters)
                {
                    listToSearch.Add(c+strNum);
                }               
            }
            string tanachText = cd.GetTanachText();
            string[] lines = tanachText.Split('\n');

            foreach(string word in listToSearch)
            {
                for (int line = 0; line < lines.Length; line++)
                {
                    string[] words = lines[line].Split(" ");
                    for (int w = 0; w < words.Length; w++)
                    {
                        if (words[w] == word)
                        {
                            resultList.Add(lines[line].Trim());
                        }
                    }
                }
            }          
            return resultList;
            }
    }
}