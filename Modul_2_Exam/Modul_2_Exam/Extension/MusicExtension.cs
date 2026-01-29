using Modul_2_Exam.Dto;
using Modul_2_Exam.Models;
using Modul_2_Exam.Service;


namespace Modul_2_Exam.Extension;

public static class MusicExtension
{
    public static double GetMusicKB(this double MB)
    {
        var KB = MB * 1024;
        return KB;
    }

    public static int GetAllLikes(this List<MusicDto> musicdto)
    {
        
        int summ = 0;
        foreach( var music in Music) 
        { 
            summ += music.Quentitylikes;
        } 
        return summ;
    }

}

