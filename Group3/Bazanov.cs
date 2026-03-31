using System;
using System.Collections.Generic;

namespace ForkKnights.GroupExample {

  //Имя класса должно быть фамилией
  public class Bazanov : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string PlaneModel;
    public int FlightHours;
    public double AccuracyRate;
    public double CombatRating;
    public bool HasFreeFlyteLicense;
    List<string> CompletedMissions;

    public Bazanov() {

      Archetype = "Cyber Detective";
      HasFreeFlyteLicense = true;

      CompletedMissions = new List<string> { "2517", "2312", "2099" };
      CompletedMissions.Add("2075");
      Name = "JetRex";
      PlaneModel = "Sinka B-2";
      CombatRating = 3.2;
      FlightHours = 3601;
    }

    public string GetJobApplication() {

      // Никогда не используйте тернарный оператор.
      string licenseText = //HasLicense ? "есть лицензия" : "лицензия в процессе оформления";

      // почему где-то есть $@, а где-то нет??? и зачем @?
      // изучите что такое вребатимные строки и интерполяция
      string JobApplicationText =
      $@"🧬 Всем привет, я {Name}, кибер-детектив ({licenseText}) на отлов электроовец," +
      $@"специализируюсь на //{Specialization} 🕶️🐑 Мои способности: сканирование бинарных снов через " +
      $@"прямой интерфейс кибердек (сейчас заряжен на {NeuroDeckCharge}%), анализ эмоциональных отпечатков" +
      $@" с точностью до {AccuracyRate}%, а также чтение памяти на уровне синапсов, если клиент подпишет" +
      " нужные бумаги 📜⚡ Ищу работу в корпорации или частном секторе: готов вести внутренние " +
      "расследования, проверять сотрудников на «человечность», консультировать по вопросам " +
      "кибербезопасности с уклоном в психологию 🤖🧠 Из сильных сторон — принципиальность, " +
      "профессионализм и умение отличать органический страх от программного сбоя 😎 Слабые " +
      "стороны — иногда слишком увлекаюсь расследованием, забываю вовремя заряжать кибердек (а " +
      $@"он сейчас на {NeuroDeckCharge}%, между прочим), и панически боюсь живых овец, даже если это " +
      "просто овцы 🐑💥 Готов к работе в любом часовом поясе, оплата — электроовцами или новыми " +
      "нейросетевыми прошивками, в идеале — и тем, и другим.";

      return JobApplicationText;
    }
  }
}