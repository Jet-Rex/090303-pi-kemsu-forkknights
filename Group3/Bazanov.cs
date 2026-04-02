using System;
using System.Collections.Generic;

namespace ForkKnights.GroupExample {

  public class Bazanov : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string PlaneModel;
    public int FlightHours;
    public double AccuracyRate;
    public double CombatRating;
    public bool HasFreeFlyteLicense;
    string CompletedMissions;

    public Bazanov() {

      Archetype = "Cyber Pylot";
      HasFreeFlyteLicense = true;

      CompletedMissions = "Прорыв через зону отчуждения (2075), Доставка груза в обход ПВО (2077), Операция «Тишина» (2075)";
      Name = "JetRex";
      PlaneModel = "Sinka B-2";
      CombatRating = 3.2;
      FlightHours = 3601;
    }

    public string GetJobApplication() {

      string licenseText;
      if (HasFreeFlyteLicense) {
        licenseText = "есть лицензия на свободные полёты ✅";
      } else {
        licenseText = "лицензия в процессе оформления ⏳";
      }

      string JobApplicationText =
      $@"🛩️ Всем привет, я {Name}, кибер-пилот ({licenseText}) на отлов электроовец," +
      $@"Летаю на //{PlaneModel}, налёт {FlightHours} часов, боевой рейтинг (Кол-во сбитыл/кол -во вылетов) {CombatRating}." +
      "🌀 Моя суперсила: «Призрачный эфир» (Ghost Spectrum)" +
      " Могу создавать ложные цели на радарах, маскировать свой корабль и подменять сигналы «свой-чужой»." +
      "Ни один радар ПВО не видит меня, если я не хочу. Это не хакерство — это мой кибер-имплант, настроенн " +
      "ый на хаос частот. " +
      "💪 Сильные стороны: 1)вывожу караваны через зоны с плотной ПВО (потери груза — 0%)," +
      "2)создаю до 12 ложных целей одним импульсом, 3) знаю все частоты военных радаров корпораций (даже " +
      "секретные). 😅 Слабые стороны: иногда увлекаюсь и глушу даже гражданские радары (потом извиняюсь)," +
      $@"📋 Выполненные операции: {CompletedMissions}. 💼 Ищу работу: эскорт с подавлением  " +
      "ПВО, разведывательные вылеты, тестирование систем РЭБ, контрабанда через закрытые сектора." +
      "Оплата — евродолларами или новыми охлаждающими модулями для импланта." +
      "🚁 P.S. Если ваш радар показывает 12 целей, а вы видите только небо — это я. Не паникуйте.";

      return JobApplicationText;
    }
  }
}