using System.ComponentModel.DataAnnotations;

namespace Lab13.Models
{
    public record QuizQuestion(int firstNumber, int secondNumber, string operation, int answer);
}
