namespace Modul_2_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

}








































































































    //namespace CRUD_2._5.Services;

    //public class SingerService : ISingerService
    //{
    //    List<Singer> Singers;
    //    public SingerService()
    //    {
    //        Singers = new List<Singer>();
    //    }

    //    public Guid AddSinger(SingerCreateDto SingerCreateDto)
    //    {
    //        var singer = new Singer()
    //        {
    //            SingerId = Guid.NewGuid(),
    //            FirstName = SingerCreateDto.FirstName,
    //            LastName = SingerCreateDto.LastName,
    //            Password = SingerCreateDto.Password,
    //            UserName = SingerCreateDto.UserName,
    //            MusicNames = SingerCreateDto.MusicNames,
    //            Ganres = SingerCreateDto.Ganres,
    //            BirthDate = SingerCreateDto.BirthDate,
    //            Awards = SingerCreateDto.Awards,
    //            TotalPlays = 0

    //        };

    //        Singers.Add(singer);
    //        return singer.SingerId;


    //    }

    //    public bool DeleteSinger(Guid singerId)
    //    {
    //        foreach (var singer in Singers)
    //        {
    //            if (singer.SingerId == singerId)
    //            {
    //                Singers.Remove(singer);
    //                return true;
    //            }
    //        }
    //        return false;
    //    }

    //    public List<SingerGetDto> GetAllSingers()
    //    {
    //        var singerGetDtos = MapToSingerGetDtoList(Singers);
    //        return singerGetDtos;
    //    }

    //    public SingerGetDto? GetSingerById(Guid singerId)
    //    {
    //        foreach (var singer in Singers)
    //        {
    //            if (singer.SingerId == singerId)
    //            {
    //                return MapToSingerGetDto(singer);
    //            }
    //        }

    //        return null;
    //    }


    //    public List<SingerGetDto> GetSingersByGenre(string genre)
    //    {
    //        var singerGetDtos = new List<SingerGetDto>();
    //        foreach (var singer in Singers)
    //        {
    //            if (singer.Ganres.Contains(genre))
    //            {
    //                singerGetDtos.Add(MapToSingerGetDto(singer));
    //            }

    //        }
    //        return singerGetDtos;
    //    }

    //    public SingerGetDto? GetSingerWithMaxAward()
    //    {
    //        if (Singers.Count == 0)
    //        {
    //            return null;
    //        }

    //        var singerWithMaxAward = Singers[0];
    //        foreach (var singer in Singers)
    //        {
    //            if (singer.Awards.Count > singerWithMaxAward.Awards.Count)
    //            {
    //                singerWithMaxAward = singer;
    //            }
    //        }
    //        return MapToSingerGetDto(singerWithMaxAward);
    //    }

    //    public SingerGetDto? GetSingerWithMaxMusic()
    //    {
    //        if (Singers.Count == 0)
    //        {

    //        }
