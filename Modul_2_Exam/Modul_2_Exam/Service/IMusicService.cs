using Modul_2_Exam.Dto;

namespace Modul_2_Exam.Service
{
    public interface IMusicService
    {
        public Guid AddMusic(CreateMusicDto createdMusicDto); // Done
        public bool UpdateMusic(CreateMusicDto updatedMusicDto, Guid id); // Done
        public bool DeleteMusic(Guid id); // Done

        public MusicDto? GetMusicById(Guid id); // Done
        public List<MusicDto>? GetAllMusicByAuthorName(string authorName); // Author name orqali // Done
        public MusicDto? GetMusicByName(string name); // Music name orqali musicni qaytarish
        public MusicDto? GetMostLikedMmusicTop();
       
        public List<MusicDto>? GetAllMusicAboveSize(double minSize); // minSize hajmidan katta musiclarni qaytarish // done
        public List<MusicDto>? GetAllMusicBelowSize(double minSize); // minSize hajmidan kam musiclarni qaytarish // done
        public List<MusicDto>? GetMostLikedMmusic(int count);// count// orqali eng ko'p like bor music larni qaytarish
        public List<MusicDto>? GetMusicWithLikesInRange(int minLike, int maxLike); // shu oraliqdagi musiclarni qaytarish
        public double GetTotalMusicSizeByAuthor(string authorName); // shu authorga tegishli qo'shiqlar hajmini qaytarish


    }
}