﻿using System.Collections.Generic;

namespace hw9.Calculator
{
    public class MathExpressionParser
    {
        private readonly HashSet<char> brackets = new HashSet<char>() { '(', ')' };
        private readonly HashSet<char> operations = new HashSet<char>() { '+', '-', '*', '/' };

        public Result<List<Token>, string> ParseToTokens(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return new Result<List<Token>, string>(new List<Token>());
            var tokens = new List<Token>();
            var number = "";
            string numberErrorMessage = "";
            foreach (var c in expression.Replace(" ", ""))
            {
                if (brackets.Contains(c))
                {
                    if (!TryAddToken(ref number, tokens, c, TokenType.Bracket))
                        return new Result<List<Token>, string>(numberErrorMessage + number);
                }
                else if (operations.Contains(c))
                {
                    if (!TryAddToken(ref number, tokens, c, TokenType.Operation))
                        return new Result<List<Token>, string>(numberErrorMessage + number);
                }
                else if (char.IsDigit(c) || c == ',' && !number.Contains(','))
                    number += c;
                else
                    return new Result<List<Token>, string>($"Unknown character {c}");
            }

            if (!string.IsNullOrEmpty(number))
                if (!double.TryParse(number, out _))
                    return new Result<List<Token>, string>(numberErrorMessage + number);
                else
                    tokens.Add(new Token(TokenType.Number, number));
            return new Result<List<Token>, string>(tokens);
        }

        private bool TryAddToken(ref string number, ICollection<Token> tokens, char tokenValue, TokenType tokenType)
        {
            if (!string.IsNullOrEmpty(number))
            {
                if (!double.TryParse(number, out _))
                    return false;
                tokens.Add(new Token(TokenType.Number, number));
                number = "";
            }

            tokens.Add(new Token(tokenType, tokenValue.ToString()));
            return true;
        }
    }
}