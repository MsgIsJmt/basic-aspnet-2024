namespace BasicDbHandling.Models
{
    // DB에 테이블로 만들어지는 엔티티 클래스
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string DisplayOrder { get; set; }
        public DateTime PostDate { get; set; } = DateTime.Now;    // 기본적으로 생성되는 현재 날짜
    }
}
