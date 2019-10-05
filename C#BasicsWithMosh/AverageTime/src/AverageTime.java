import java.util.Scanner;

public class AverageTime {


    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter your time per hour");
        int kmPerHour = scanner.nextInt();

        System.out.println("Enter your time of running");
        int timeOfRunning = scanner.nextInt();

        findDistance(kmPerHour, timeOfRunning);
    }

    private static void findDistance(int a, float b) {
        float distance;
        distance = b / 60 * a;
        System.out.println("Your distance is " + distance + " km");
    }
}
