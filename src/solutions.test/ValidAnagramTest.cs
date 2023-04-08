﻿namespace solutions.test.easy;
using Shouldly;
using solutions.easy;

/// <summary>
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
/// Example 1: Input: s = "anagram", t = "nagaram" Output: true 
/// Example 2: Input: s = "rat", t = "car" Output: false
/// Constraints:
/// 1 <= s.length, t.length <= 5 * 104
/// s and t consist of lowercase English letters.
/// Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
/// </summary>
public class ValidAnagramTest
{
    [Theory]
    [InlineData("rat", "car", false)]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("crot", "troc", true)]
    [InlineData("a", "b", false)]
    [InlineData("accc", "caaa", false)]
    public void Numse1231_RT(string s, string t, bool expected)
    {
        new ValidAnagramSolver()
            .IsAnagram(s, t)
            .ShouldBe(expected);
    }
}