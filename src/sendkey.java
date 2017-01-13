import java.awt.Robot;
import java.awt.event.KeyEvent;
public class sendkey {
	//키보드 제어
	//1:A 2:S 3:d 4:w
	public static void key(int input, int time){
		try {
	        Robot robot = new Robot();
	        switch (input) {
	        case 1:
	        	robot.keyPress(KeyEvent.VK_A);
	        	Thread.sleep(time);
		        robot.keyRelease(KeyEvent.VK_A);
	            break;
	        case 2:
	        	robot.keyPress(KeyEvent.VK_S);
	        	Thread.sleep(time);
		        robot.keyRelease(KeyEvent.VK_S);
	            break;
	        case 3:
	        	robot.keyPress(KeyEvent.VK_D);
	        	Thread.sleep(time);
		        robot.keyRelease(KeyEvent.VK_D);
	            break;
	        case 4:
	        	robot.keyPress(KeyEvent.VK_W);
	        	Thread.sleep(time);
		        robot.keyRelease(KeyEvent.VK_W);
	            break;
	        default:
	        	System.out.println("No Key:"+input+"-"+time);
	            break;
	        }
		} catch (Exception e) {
		        e.printStackTrace();
		}
	}
}
