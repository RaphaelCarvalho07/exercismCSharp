using System;
class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        int expectedMinutes = 40;
        return expectedMinutes;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
        public int RemainingMinutesInOven(int minutesInOven) {
            var lasagna = new Lasagna();
            var expectedTime = lasagna.ExpectedMinutesInOven();
            int remainingMinutes = expectedTime - minutesInOven;
            return remainingMinutes;            
        }
    // TODO: define the 'PreparationTimeInMinutes()' method
        public int PreparationTimeInMinutes(int layers) {
            int timeSpent = layers * 2;
            return timeSpent;
        }
    // TODO: define the 'ElapsedTimeInMinutes()' method
        public int ElapsedTimeInMinutes(int timeSpent, int minutesInOven) {
            var lasagna = new Lasagna();
            var timePreparation = lasagna.PreparationTimeInMinutes(timeSpent);
            var elapsedTime = timePreparation + minutesInOven;
            return elapsedTime;
        }
}
