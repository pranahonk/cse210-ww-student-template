using System;

public class Fraction
{
    // Private member variables
    private int _numerator;
    private int _denominator;

    // No-parameter constructor: initializes to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // One-parameter constructor: numerator provided, denominator set to 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Two-parameter constructor: both numerator and denominator provided
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and setters for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int value)
    {
        _numerator = value;
    }

    // Getters and setters for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = value;
    }

    // Returns a string in the form "numerator/denominator" (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Returns the decimal value (double) of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}