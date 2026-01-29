using Modul_2_Exam.Dto;
using Modul_2_Exam.Models;

namespace Modul_2_Exam.Service;

public class MusicService : IMusicService
{
    List<Music> Musics;
    public MusicService()
    {
        Musics = new List<Music>();
    }
    private MusicDto MusicDtoo(Music music)
    {
        var musicDto = new MusicDto();
        musicDto.MusicId = music.MusicId;
        musicDto.Name = music.Name;
        music.AuthorName = music.AuthorName;
        musicDto.Description = music.Description;
        music.Quentitylikes = music.Quentitylikes;
        music.MB = music.MB;
        return musicDto;
    }
    public Guid AddMusic(CreateMusicDto createMusicDto)
    {
        var music = new Music()
        {
            MusicId = Guid.NewGuid(),
            Name = createMusicDto.Name,
            MB = createMusicDto.MB,
            AuthorName = createMusicDto.AuthorName,
            Quentitylikes = createMusicDto.Quentitylikes,
            Description = createMusicDto.Description,

        };

        Musics.Add(music);
        return music.MusicId;

    }
    public bool DeleteMusic(Guid DeletId)
    {
        foreach (var music in Musics)
        {
            if (music.MusicId == DeletId)
            {
                Musics.Remove(music);
                return true;
            }
        }
        return false;
    }

    public bool UpdateMusic(CreateMusicDto updatedMusicDto, Guid uptadeId)
    {
        foreach (var music in Musics)
        {
            if (music.MusicId == uptadeId)
            {
                music.Name = updatedMusicDto.Name;
                music.MB = updatedMusicDto.MB;
                music.Quentitylikes = updatedMusicDto.Quentitylikes;
                music.AuthorName = updatedMusicDto.AuthorName;
                music.Description = updatedMusicDto.Description;
                return true;
            }
        }
        return false;
    }

    public List<MusicDto> GetMusics()
    {
        var musics = new List<MusicDto>();
        foreach (var music in Musics)
        {
            musics.Add(MusicDtoo(music));
        }
        return musics;
    }

    public MusicDto? GetMusicById(Guid id)
    {
        foreach (var music in Musics)
        {
            if (music.MusicId == id)
            {
                return MusicDtoo(music);
            }
        }
        return null;
    }



    public List<MusicDto> GetAllMusicByAuthorName(string authorName)
    {
        var musicDto = new List<MusicDto>();
        foreach (var music in Musics)
        {
            if (music.AuthorName == authorName)
            {
                musicDto.Add(MusicDtoo(music));
            }

        }
        return musicDto;
    }
    public MusicDto GetMostLikedMmusicTop()
    {
        var musicDto = new MusicDto();
        var MostLikedMusic = Musics[0];

        foreach (var music in Musics)
        {
            if (MostLikedMusic.Quentitylikes < music.Quentitylikes)
            {
                MostLikedMusic = music;
            }
        }
        return MusicDtoo(MostLikedMusic);
    }
    public List<MusicDto>? GetMostLikedMmusic(int count)
    {
        var musicDto = new List<MusicDto>();
        Musics.Sort();
        foreach (var music in Musics)
        {
            musicDto.Add(MusicDtoo(music));
        }
        return musicDto;

    }
    public MusicDto? GetMusicByName(string name)
    {
        var musics = new MusicDto();
        foreach (var music in Musics)
        {
            if (music.Name == name)
            {

                return MusicDtoo(music);
            }
        }
        return null;
    }

    public List<MusicDto>? GetAllMusicAboveSize(double minSize)
    {
        var musics = new List<MusicDto>();

        foreach (var music in Musics)
        {
            if (music.MB > minSize)
            {
                musics.Add(MusicDtoo(music));
            }
        }
        return null;
    }

    public List<MusicDto>? GetAllMusicBelowSize(double minSize)
    {
        var musics = new List<MusicDto>();

        foreach (var music in Musics)
        {
            if (music.MB < minSize)
            {
                musics.Add(MusicDtoo(music));
            }
        }
        return null;

    }
    public List<MusicDto>? GetMusicWithLikesInRange(int minLike, int maxLike)
    {
        var musicRange = new List<MusicDto>();
        foreach (var music in Musics)
        {
            if (music.Quentitylikes < minLike && music.Quentitylikes < maxLike)
            {
                musicRange.Add(MusicDtoo(music));
            }
        }
        return null;
    }


    public double GetTotalMusicSizeByAuthor(string authorName)
    {
        double summ = 0;
        foreach (var music in Musics)
        {
            if (music.AuthorName == authorName)
            {
                summ += music.MB;
            }
        }

        return summ;

    }

 

    //List<MusicDto>? IMusicService.GetMusicWithLikesInRange(int minLike, int maxLike)
    //{
    //    throw new NotImplementedException();
    //}
}


