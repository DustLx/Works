package com.example.lab11;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.TextField;
import javafx.scene.text.Text;

import java.net.URL;
import java.util.ResourceBundle;

import java.io.FileWriter;
import java.io.IOException;
import java.io.File;

import java.util.ArrayList;


public class CalcController implements Initializable {

    @FXML
    private Text outputField;

    private long a = 0;
    private long b = 0;
    private String result = "";

    private boolean start = false; // why even need???
    private boolean isOperatorPressed = false;

    private String oper = "";
    private final Model model = new Model();

    public CalcController() {
    }


    class History {
        ArrayList<String[]> history = new ArrayList<>();

        void save() {
            history.add(new String[]{String.valueOf(a), oper, String.valueOf(b), "=", result});
        }

        String[] getElement(int num) {
            if (history.isEmpty() && num < 1) return null;
            return history.get(history.size() - num);
        }

        ArrayList<String[]> getHistory() {
            if (history.isEmpty()) return null;
            return history;
        }
    }


    History history = new History();


    private final String[] NumeralSystems = {"Decimal", "Binary", "Octal", "Hexadecimal"};
    private final String[] ByteChoiceboxList = {"8", "4", "2", "1"};
    private final String[] AutoleasingChoiceboxList = {"Регулярный платёж", "А других значений", "в примере меню",
            "не было)", "Но есть пасхалка)"};
    String CurrentNumeralSystem = NumeralSystems[0];
    String CurrentByte = ByteChoiceboxList[0];
    String CurrentAutoleasing = AutoleasingChoiceboxList[0];


    @FXML
    private ChoiceBox<String> NumeralSystemChoiceBox;
    @FXML
    private ChoiceBox<String> ByteChoiceBox;
    @FXML
    private ChoiceBox<String> AutoleasingChoiceBox;


    // Ненужная функция для принта логов, использовал для тестирования,
    // все фрагменты с её использоанием можно спокойно удалить из кода
    void printlog(String msg) {
        System.out.println("[Log]: " + msg);
    }


    private long toNum(String str) {
        return switch (CurrentNumeralSystem) {
            case "Decimal" -> Long.parseLong(str);
            case "Binary" -> Long.parseLong(str, 2);
            case "Octal" -> Long.parseLong(str, 8);
            case "Hexadecimal" -> Long.parseLong(str, 16);
            default -> throw new IllegalStateException("Unexpected value: " + CurrentNumeralSystem);
        };
    }


    private String toNumsys(long num) {
        return switch (CurrentNumeralSystem) {
            case "Decimal" -> Long.toString(num);
            case "Binary" -> Long.toBinaryString(num);
            case "Octal" -> Long.toOctalString(num);
            case "Hexadecimal" -> Long.toHexString(num);
            default -> throw new IllegalStateException("Unexpected value: " + CurrentNumeralSystem);
        };
    }


    @FXML
    private void numPressed(ActionEvent event) {
        if (start) {
            outputField.setText(""); //reset output text
            start = false; // not start
            return;
        }

        if (!result.isEmpty()) {
            outputField.setText(result);
            result = "";
        }
        String value = ((Button)event.getSource()).getText(); // button value

        // change text to existing text + new button value
        outputField.setText(outputField.getText() + value);
        printlog("text updated");
        if (isOperatorPressed) b = // updating b
                toNum(b + value); // adding new num to b
    }


    @FXML
    private void operatorPressed(ActionEvent event) {
        if (!result.isEmpty()) {
            outputField.setText(result);
            result = "";
        }

        String outputText = outputField.getText(); // output field value

        if (!isOperatorPressed)
            a = toNum(outputText); // setting value for num a

        else // if changing operator
            // removing previous oper from output
            outputText = outputText.substring(0, outputText.length()-3);

        isOperatorPressed = true;
        oper = ((Button)event.getSource()).getText(); // updating an oper value

        outputField.setText(outputText + " " + oper + "\n"); // change output text

    }


    @FXML
    private void calculate() {
        // Проверка на уникальные ситуации
        if (oper.equals("÷") && b == 0) result = "Ошибка: Результат содержит ∞.";
        if (oper.equals("√") && b < 0) result = "Ошибка: Результат содержит мнимые числа.";

        else
            result = toNumsys(model.calculation(a, b, oper));
        // calculation
        outputField.setText(
                toNumsys(a) + " " + oper + " " + toNumsys(b) +
                " =\n" + result);

        // Делал тесты, они тут не нужны
        printlog("toNumsys(a) = " + toNumsys(a));
        printlog("toNumsys(b) = " + toNumsys(b));
        printlog("toNumsys(model.calculation(a, b, oper)) = "
                + toNumsys(model.calculation(a, b, oper)));

        history.save();

        //resetting values
        oper = "";
        a = 0;
        b = 0;
        start = false;
        isOperatorPressed = false;

        printlog("CurrentNumeralSystem = " + CurrentNumeralSystem);
    }


    @FXML
    private void clear() {
        outputField.setText("");
        a = 0;
        b = 0;
        oper = "";
        start = false;
        isOperatorPressed = false;
    }


    @FXML private Button ButtonA;
    @FXML private Button ButtonB;
    @FXML private Button ButtonC;
    @FXML private Button ButtonD;
    @FXML private Button ButtonE;
    @FXML private Button ButtonF;

    @FXML private Button Button2;
    @FXML private Button Button3;
    @FXML private Button Button4;
    @FXML private Button Button5;
    @FXML private Button Button6;
    @FXML private Button Button7;
    @FXML private Button Button8;
    @FXML private Button Button9;

    public void switchHexadecimal(boolean value) {
        value = !value;

        ButtonA.setDisable(value);
        ButtonB.setDisable(value);
        ButtonC.setDisable(value);
        ButtonD.setDisable(value);
        ButtonE.setDisable(value);
        ButtonF.setDisable(value);
    }


    public void switchDecimal(boolean value) {
        value = !value;

        Button9.setDisable(value);
        Button8.setDisable(value);
    }


    public void switchOctal(boolean value) {
        value = !value;

        Button7.setDisable(value);
        Button6.setDisable(value);
        Button5.setDisable(value);
        Button4.setDisable(value);
        Button3.setDisable(value);
        Button2.setDisable(value);
    }


    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        NumeralSystemChoiceBox.getItems().addAll(NumeralSystems);
        NumeralSystemChoiceBox.setValue(NumeralSystems[0]);
        NumeralSystemChoiceBox.setOnAction(this::BinarySystemSelect);

        ByteChoiceBox.getItems().addAll(ByteChoiceboxList);
        ByteChoiceBox.setValue(ByteChoiceboxList[0]);

        AutoleasingChoiceBox.getItems().addAll(AutoleasingChoiceboxList);
        AutoleasingChoiceBox.setValue(AutoleasingChoiceboxList[0]);

        switchHexadecimal(false);
    }


    public void BinarySystemSelect(ActionEvent event) {
        CurrentNumeralSystem = NumeralSystemChoiceBox.getValue();

        switch (CurrentNumeralSystem) {
            case "Binary" -> {
                switchOctal(false);
                switchDecimal(false);
                switchHexadecimal(false);
            }
            case "Octal" -> {
                switchOctal(true);
                switchDecimal(false);
                switchHexadecimal(false);
            }
            case "Decimal" -> {
                switchHexadecimal(false);
                switchDecimal(true);
                switchOctal(true);
            }
            case "Hexadecimal" -> {
                switchHexadecimal(true);
                switchDecimal(true);
                switchOctal(true);
            }
            default -> throw new IllegalStateException("Unexpected value: " + CurrentNumeralSystem);
        }

        printlog("CurrentNumeralSystem = " + CurrentNumeralSystem);
    }


    // Autoleasing


    @FXML
    private Text AutoleasingOutput;
    @FXML
    private TextField rentPrice;
    @FXML
    private TextField rentPeriod;
    @FXML
    private TextField annualPayments;
    @FXML
    private TextField residualValue;
    @FXML
    private TextField interestRate;


    public boolean isNumeric(String str) {
        try {
            Double.parseDouble(str);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }


    @FXML
    private void AutoleasingCalc() {
        // Проверка на уникальные ситуации
        if (!isNumeric(rentPrice.getText()) ||
                !isNumeric(rentPeriod.getText()) ||
                !isNumeric(annualPayments.getText()) ||
                !isNumeric(residualValue.getText()) ||
                !isNumeric(interestRate.getText()) ||
                Integer.parseInt(interestRate.getText()) > 100 ||
                Integer.parseInt(interestRate.getText()) < 0) AutoleasingOutput.setText("Неккоректные значения.");

        else AutoleasingOutput.setText("Я не знаю, как должен считать калькулятор автолизинга. Но у меня есть кот. (=^-ω-^=)");
    }


    @FXML
    private void unrealizedEvent() {
        result = "0";
        outputField.setText("Автор ещё не доучился, поэтому понятия не имеет, что должна делать эта кнопка.");
    }


    @FXML
    private void exportHistory() {

        ArrayList<String[]> array = history.getHistory();

        String fileName = "array_values.txt";

        // Обнаружение или создание файла
        try {
            File file = new File(fileName);

            if (file.createNewFile()) System.out.println("Файл не обнаружен, создан новый файл " + file.getName() + ".");
            else System.out.println("Файл обнаружен");
        } catch (IOException e) {
            System.out.println("Произошла ошибка при обнаружении файла: " + e.getMessage());
        }

        // Запись в файл
        try {
            FileWriter writer = new FileWriter(fileName);

            for (String[] strings : array) {
                for (String string : strings) {
                    writer.write(string + " ");
                }
                writer.write("\n");
            }

            writer.close();
            System.out.println("История успешно сохранена в файл " + fileName);
        } catch (IOException e) {
            System.out.println("Произошла ошибка записи в файл: " + e.getMessage());
        }
    }
}
