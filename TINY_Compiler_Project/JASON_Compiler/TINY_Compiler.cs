﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TINY_Compiler
{
    public static class TINY_Compiler
    {
        

        public static Scanner TINY_Scanner = new Scanner();
        public static Parser TINY_Parser = new Parser();
        public static List<string> Lexemes= new List<string>();
        public static List<Token> TokenStream = new List<Token>();
        public static Node treeroot;


        public static void Start_Compiling(string SourceCode) //character by character
        {
            //Scanner
 
            TINY_Scanner.StartScanning(SourceCode);
            //Parser
            TINY_Parser.StartParsing(TokenStream);
            treeroot = TINY_Parser.root;
            //Sematic Analysis
        } 


        static void SplitLexemes(string SourceCode)
        {
            string[] Lexemes_arr=SourceCode.Split(' ');
            for(int i=0; i< Lexemes_arr.Length; i++)
            {
                if(Lexemes_arr[i].Contains("\r\n"))
                {
                    Lexemes_arr[i] = Lexemes_arr[i].Replace("\r\n", string.Empty);
                }
                Lexemes.Add(Lexemes_arr[i]);
            }

        }

        
    }
}
