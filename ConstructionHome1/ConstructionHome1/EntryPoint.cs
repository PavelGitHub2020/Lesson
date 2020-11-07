using System;

namespace ConstructionHome1
{

    class EntryPoint
    {
        //Реализовать программу Строительства дома.
        //Реализовать:
        //-классы
        //--House(дом), Basement(фундамент), Walls(стены), Door(дверь), Window(окно), Roof(крыша).
        //--Team(бригада строителей), Worker(строитeль), TeamLeader(бригадир).

        //-интерфейсы
        //--IPart, IWorker
        //Все части дома должны реализовать интерфейс IPart(часть дома), для рабочих и бригадира
        //предоставляется базовый интерфейс IWorker(рабочий).

        //Бригада строителей (Team) строит дом (House). Дом состоит из фундамента(Basement), стен(Walls),
        //окон(Window), дверей(Door), крыши(Part).

        //Согласно проекту дом состоит из 1 фундамента, 4 стены, 1 дверь, 4 окна и одна крыша.
        //Бригада начинает работу, и строители последовательно строят дом начиная с фундамента
        //Каждый строитель не знает заранее на чем завершился предыдущий этап строительства,
        //поэтому он проверяет , что уже построено и продолжает работу. Если в игру вступает 
        //бригадир(TeamLeader), он не строит, а формирует отчет, что уже построено 
        //и какая часть работы выполнена
        static void Main(string[] args)
        {
            House house = new House();

            Team team = new Team();

            Random random = new Random();

            for (int i = 0; i < random.Next(0, 11); i++)//рандомно выбираем кол-во обьектов, которые построятся
            {
                team.workers[random.Next(0, 4)].BuildHoude(house, team.teamLeader);//от 0 до 4, потому что установлено 5 рабочих
            }

            foreach (var message in team.teamLeader.report)
            {
                Console.WriteLine(message);
            }
            
            team.teamLeader.Report();
        }
    }
}
