using Composite_Pattern;

public class Program
{
    static void Main(string[] args)
    {
        // Создаем документ
        Document document = new Document();

        // Создаем разделы
        Section section1 = new Section("Введение");
        Section section2 = new Section("Глава 1");
        Section section3 = new Section("Глава 2");

        // Создаем параграфы
        Paragraph paragraph1 = new Paragraph("Первый параграф введения.");
        Paragraph paragraph2 = new Paragraph("Второй параграф введения.");
        Paragraph paragraph3 = new Paragraph("Первый параграф главы 1.");
        Paragraph paragraph4 = new Paragraph("Второй параграф главы 1.");

        // Добавляем параграфы в разделы
        section1.Add(paragraph1);
        section1.Add(paragraph2);
        section2.Add(paragraph3);
        section2.Add(paragraph4);

        // Добавляем разделы в документ
        document.Add(section1);
        document.Add(section2);
        document.Add(section3);

        // Выводим структуру документа
        document.Display(0);

        Console.ReadKey();
    }

}