
package neyapsam;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Ingredient {
    private int id;
    private String name;
    private int calories;
    
    private Connection conn;
    String dbUrl = "jdbc:derby://localhost:1527/NeYapsamDatabase";
    String user = "NeYapsam";
    String pass = "NeYapsam!db";

    public Connection connect() {
        try {
            Class.forName("org.apache.derby.jdbc.ClientDriver").newInstance();
            System.out.println("Connection successful");
            conn = DriverManager.getConnection(dbUrl, user, pass);
        } catch (ClassNotFoundException | IllegalAccessException | InstantiationException | SQLException e) {
            System.out.println("Connection error");
        }
        return conn;
    }
    
    public Ingredient() {
        id = 0;
        name = "Null";
        calories = 0;
    }
    
    public Ingredient(int id,String name,int calories) {
        this.id = id;
        this.name = name;
        this.calories = calories;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getCalories() {
        return calories;
    }

    public void setCalories(int calories) {
        this.calories = calories;
    }
}
