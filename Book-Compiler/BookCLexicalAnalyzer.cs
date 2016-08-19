using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_compiler
{
    public partial class BookCLexicalAnalyzer : Form
    {
        public BookCLexicalAnalyzer()
        {
            InitializeComponent();
        }

        public void lexicalcheck()
        {
            //prologue
            string sourcecode =rtbxNotepad.Text+" ";
            char[] scarr =sourcecode.ToCharArray();
            string val ="Valid", inval ="Invalid";
            int idenctr = 0, numctr = 0, decctr = 0, strctr = 0, cmntctr = 0;
            string idenstr = "", numstr = "", decstr = "", strstr = "";
            Regex RGalpnum = new Regex(@"^[a-zA-Z0-9]*$");  //Regex RGalpnum = new Regex(@"^[a-zA-Z0-9\s,]*$"); // alphanumeric
            Regex RGnum09 = new Regex(@"^[0-9]+$"); // numbers
            Regex RGnum19 = new Regex(@"^[1-9]+$"); // numbers
            Regex RGalp = new Regex(@"^[a-zA-Z]+$"); // alpha
            Regex RGascii = new Regex(@"."); // ascii michael
            int i =0;
            while (i < sourcecode.Length)
            {
                #region  WORDS

                if (scarr[i] == 'a')
                    if (scarr[i + 1] == 's')
                        if (scarr[i + 2] == ' ') //space
                        {
                            string[] row = { "as", "as", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "as", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'as' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "a", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'a' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'b')
                    if (scarr[i + 1] == 'i')
                        if (scarr[i + 1] == 'i' && scarr[i + 2] == 'n')
                            if (scarr[i + 3] == ' ') //space
                            {
                                string[] row = { "bin", "bin", val };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += 2;
                            }
                            else
                            {
                                string[] row = { "bin", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'bin' - invalid look ahead '" + scarr[i + 3] + "'\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "bi", " ", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'bi' - invalid reserved word\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == 'l')
                        if (scarr[i + 1] == 'l' && scarr[i + 2] == 'a')
                            if (scarr[i + 1] == 'l' && scarr[i + 2] == 'a' && scarr[i + 3] == 'n')
                                if (scarr[i + 1] == 'l' && scarr[i + 2] == 'a' && scarr[i + 3] == 'n' && scarr[i + 4] == 'k')
                                    if (scarr[i + 5] == ' ') //space
                                    {
                                        string[] row = { "blank", "blank", val };
                                        var listViewItem = new ListViewItem(row);
                                        lvLexeme.Items.Add(listViewItem);
                                        i += 4;
                                    }
                                    else
                                    {
                                        string[] row = { "blank", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'blank' - invalid look ahead '" + scarr[i + 5] + "'\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "blan", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'blan' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "bla", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'bla' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "bl", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'bl' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "b", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'b' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'c')
                    if (scarr[i + 1] == 'h')
                        if (scarr[i + 1] == 'h' && scarr[i + 2] == 'a')
                            if (scarr[i + 1] == 'h' && scarr[i + 2] == 'a' && scarr[i + 3] == 'p')
                                if (scarr[i + 1] == 'h' && scarr[i + 2] == 'a' && scarr[i + 3] == 'p' && scarr[i + 4] == 't')
                                    if (scarr[i + 1] == 'h' && scarr[i + 2] == 'a' && scarr[i + 3] == 'p' && scarr[i + 4] == 't' && scarr[i + 5] == 'e')
                                        if (scarr[i + 1] == 'h' && scarr[i + 2] == 'a' && scarr[i + 3] == 'p' && scarr[i + 4] == 't' && scarr[i + 5] == 'e' && scarr[i + 6] == 'r')
                                            if (scarr[i + 7] == ' ') //space
                                            {
                                                string[] row = { "chapter", "chapter", val };
                                                var listViewItem = new ListViewItem(row);
                                                lvLexeme.Items.Add(listViewItem);
                                                i += 6;
                                            }
                                            else
                                            {
                                                string[] row = { "chapter", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'chapter' - invalid look ahead '" + scarr[i + 7] + "'\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "chapte", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'chapte' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "chapt", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'chapt' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "chap", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'chap' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "cha", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'cha' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "ch", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'ch' - invalid reserved word\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == 'l')
                        if (scarr[i + 1] == 'l' && scarr[i + 2] == 'i')
                            if (scarr[i + 1] == 'l' && scarr[i + 2] == 'i' && scarr[i + 3] == 'm')
                                if (scarr[i + 1] == 'l' && scarr[i + 2] == 'i' && scarr[i + 3] == 'm' && scarr[i + 4] == 'a')
                                    if (scarr[i + 1] == 'l' && scarr[i + 2] == 'i' && scarr[i + 3] == 'm' && scarr[i + 4] == 'a' && scarr[i + 5] == 'x')
                                        if (scarr[i + 6] == ' ' || scarr[i + 6] == '(') //delim10
                                        {
                                            string[] row = { "climax", "climax", val };
                                            var listViewItem = new ListViewItem(row);
                                            lvLexeme.Items.Add(listViewItem);
                                            i += 5;
                                        }
                                        else
                                        {
                                            string[] row = { "climax", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'climax' - invalid look ahead '" + scarr[i + 6] + "'\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "clima", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'clima' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "clim", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'clim' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "cli", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'cli' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "cl", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'cl' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "c", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'c' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'd')
                    if (scarr[i + 1] == 'e')
                        if (scarr[i + 1] == 'e' && scarr[i + 2] == 'c')////////////////////////////
                            if (scarr[i + 3] == ' ') //Space
                            {
                                string[] row = { "dec", "dec", val };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += 2;
                            }
                            else
                            {
                                string[] row = { "dec", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'dec' - invalid look ahead '" + scarr[i + 3] + "'\n";
                                i += 2;
                            }
                        else if (scarr[i + 1] == 'e' && scarr[i + 2] == 'l') //////////////////////////
                            if (scarr[i + 1] == 'e' && scarr[i + 2] == 'l' && scarr[i + 3] == 'i')
                                if (scarr[i + 1] == 'e' && scarr[i + 2] == 'l' && scarr[i + 3] == 'i' && scarr[i + 4] == 'v')
                                    if (scarr[i + 1] == 'e' && scarr[i + 2] == 'l' && scarr[i + 3] == 'i' && scarr[i + 4] == 'v' && scarr[i + 5] == 'e')
                                        if (scarr[i + 1] == 'e' && scarr[i + 2] == 'l' && scarr[i + 3] == 'i' && scarr[i + 4] == 'v' && scarr[i + 5] == 'e' && scarr[i + 6] == 'r')
                                            if (scarr[i + 7] == ' ' || scarr[i + 7] == '<') //delim30
                                            {
                                                string[] row = { "deliver", "deliver", val };
                                                var listViewItem = new ListViewItem(row);
                                                lvLexeme.Items.Add(listViewItem);
                                                i += 6;
                                            }
                                            else
                                            {
                                                string[] row = { "deliver", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'deliver' - invalid look ahead '" + scarr[i + 7] + "'\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "delive", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'delive' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "deliv", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'deliv' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "deli", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'deli' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "del", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'del' - invalid reserved word\n";
                                i += 2;
                            }
                        else if (scarr[i + 1] == 'e' && scarr[i + 2] == 'f')
                            if (scarr[i + 1] == 'e' && scarr[i + 2] == 'f' && scarr[i + 3] == 'a')
                                if (scarr[i + 1] == 'e' && scarr[i + 2] == 'f' && scarr[i + 3] == 'a' && scarr[i + 4] == 'u')
                                    if (scarr[i + 1] == 'e' && scarr[i + 2] == 'f' && scarr[i + 3] == 'a' && scarr[i + 4] == 'u' && scarr[i + 5] == 'l')
                                        if (scarr[i + 1] == 'e' && scarr[i + 2] == 'f' && scarr[i + 3] == 'a' && scarr[i + 4] == 'u' && scarr[i + 5] == 'l' && scarr[i + 6] == 't')
                                            if (scarr[i + 7] == ':') //colon
                                            {
                                                string[] row = { "default", "default", val };
                                                var listViewItem = new ListViewItem(row);
                                                lvLexeme.Items.Add(listViewItem);
                                                i += 6;
                                            }
                                            else
                                            {
                                                string[] row = { "default", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'default' - invalid look ahead '" + scarr[i + 7] + "'\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "defaul", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'defaul' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "defau", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'defau' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "defa", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'defa' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "def", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'def' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "de", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'de' - invalid reserved word\n";
                            i += 1;
                        }

                    else if (scarr[i + 1] == 'u')
                        if (scarr[i + 1] == 'u' && scarr[i + 2] == 'r')
                            if (scarr[i + 1] == 'u' && scarr[i + 2] == 'r' && scarr[i + 3] == 'i')
                                if (scarr[i + 1] == 'u' && scarr[i + 2] == 'r' && scarr[i + 3] == 'i' && scarr[i + 4] == 'n')
                                    if (scarr[i + 1] == 'u' && scarr[i + 2] == 'r' && scarr[i + 3] == 'i' && scarr[i + 4] == 'n' && scarr[i + 5] == 'g')
                                        if (scarr[i + 6] == ' ' || scarr[i + 6] == '(') //delim10
                                        {
                                            string[] row = { "during", "during", val };
                                            var listViewItem = new ListViewItem(row);
                                            lvLexeme.Items.Add(listViewItem);
                                            i += 5;
                                        }
                                        else
                                        {
                                            string[] row = { "during", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'during' - invalid look ahead '" + scarr[i + 6] + "'\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "durin", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'durin' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "duri", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'duri' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "dur", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'dur' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "du", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'du' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "d", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'd' - invalid reserved word\n";
                    }

                else if (scarr[i] == 'e')
                    if (scarr[i + 1] == 'm')
                        if (scarr[i + 1] == 'm' && scarr[i + 2] == 'p')
                            if (scarr[i + 1] == 'm' && scarr[i + 2] == 'p' && scarr[i + 3] == 't')
                                if (scarr[i + 1] == 'm' && scarr[i + 2] == 'p' && scarr[i + 3] == 't' && scarr[i + 4] == 'y')
                                    if (scarr[i + 5] == ',' || scarr[i + 5] == ':') //delim1
                                    {
                                        string[] row = { "empty", "empty", val };
                                        var listViewItem = new ListViewItem(row);
                                        lvLexeme.Items.Add(listViewItem);
                                        i += 4;
                                    }
                                    else
                                    {
                                        string[] row = { "empty", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'empty' - invalid look ahead '" + scarr[i + 5] + "'\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "empt", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'empt' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "emp", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'emp' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "em", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'em' - invalid reserved word\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == 'p')
                        if (scarr[i + 1] == 'p' && scarr[i + 2] == 'i')
                            if (scarr[i + 1] == 'p' && scarr[i + 2] == 'i' && scarr[i + 3] == 'l')
                                if (scarr[i + 1] == 'p' && scarr[i + 2] == 'i' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o')
                                    if (scarr[i + 1] == 'p' && scarr[i + 2] == 'i' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o' && scarr[i + 5] == 'g')
                                        if (scarr[i + 1] == 'p' && scarr[i + 2] == 'i' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o' && scarr[i + 5] == 'g' && scarr[i + 6] == 'u')
                                            if (scarr[i + 1] == 'p' && scarr[i + 2] == 'i' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o' && scarr[i + 5] == 'g' && scarr[i + 6] == 'u' && scarr[i + 7] == 'e')
                                                if (scarr[i + 8] == '\n') //delim32
                                                {
                                                    string[] row = { "epilogue", "epilogue", val };
                                                    var listViewItem = new ListViewItem(row);
                                                    lvLexeme.Items.Add(listViewItem);
                                                    i += 7;
                                                }
                                                else
                                                {
                                                    string[] row = { "epilogue", "", inval };
                                                    var listViewItem = new ListViewItem(row);
                                                    //lvLexeme.Items.Add(listViewItem);
                                                    rtbxerrorlist.Text += "Lexical Error: 'epilogue' - invalid look ahead '" + scarr[i + 8] + "'\n";
                                                    i += 7;
                                                }
                                            else
                                            {
                                                string[] row = { "epilogu", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'epilogu' - invalid reserved word\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "epilog", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'epilog' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "epilo", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'epilo' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "epil", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'epil' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "epi", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'epi' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "ep", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'ep' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "e", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'e' - invalid reserved word\n";
                    }

                else if (scarr[i] == 'f')
                    if (scarr[i + 1] == 'a')
                        if (scarr[i + 1] == 'a' && scarr[i + 2] == 'n')
                            if (scarr[i + 1] == 'a' && scarr[i + 2] == 'n' && scarr[i + 3] == 't')
                                if (scarr[i + 1] == 'a' && scarr[i + 2] == 'n' && scarr[i + 3] == 't' && scarr[i + 4] == 'a')
                                    if (scarr[i + 1] == 'a' && scarr[i + 2] == 'n' && scarr[i + 3] == 't' && scarr[i + 4] == 'a' && scarr[i + 5] == 's')
                                        if (scarr[i + 1] == 'a' && scarr[i + 2] == 'n' && scarr[i + 3] == 't' && scarr[i + 4] == 'a' && scarr[i + 5] == 's' && scarr[i + 6] == 'y')
                                            if (scarr[i + 7] == ' ' || scarr[i + 7] == ':' || scarr[i + 7] == ',' || scarr[i + 7] == ')') //delim20
                                            {
                                                string[] row = { "fantasy", "fantasy", val };
                                                var listViewItem = new ListViewItem(row);
                                                lvLexeme.Items.Add(listViewItem);
                                                i += 6;
                                            }
                                            else
                                            {
                                                string[] row = { "fantasy", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'fantasy' - invalid look ahead '" + scarr[i + 7] + "'\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "fantas", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'fantas' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "fanta", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'fanta' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "fant", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'fant' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "fan", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'fan' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "fa", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'fa' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "f", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'f' - invalid reserved word\n";
                    }

                else if (scarr[i] == 'i')
                    if (scarr[i + 1] == 'f')
                        if (scarr[i + 1] == 'f' && scarr[i + 2] == 'n')
                            if (scarr[i + 1] == 'f' && scarr[i + 2] == 'n' && scarr[i + 3] == 'o')
                                if (scarr[i + 1] == 'f' && scarr[i + 2] == 'n' && scarr[i + 3] == 'o' && scarr[i + 4] == 't')
                                    if (scarr[i + 5] == ' ' || scarr[i + 5] == '[') //delim14
                                    {
                                        string[] row = { "ifnot", "ifnot", val };
                                        var listViewItem = new ListViewItem(row);
                                        lvLexeme.Items.Add(listViewItem);
                                        i += 4;
                                    }
                                    //////
                                    else if (scarr[i + 1] == 'f' && scarr[i + 2] == 'n' && scarr[i + 3] == 'o' && scarr[i + 4] == 't' && scarr[i + 5] == 't') //////////////////////////////////////////////////////////
                                        if (scarr[i + 1] == 'f' && scarr[i + 2] == 'n' && scarr[i + 3] == 'o' && scarr[i + 4] == 't' && scarr[i + 5] == 't' && scarr[i + 6] == 'h')
                                            if (scarr[i + 1] == 'f' && scarr[i + 2] == 'n' && scarr[i + 3] == 'o' && scarr[i + 4] == 't' && scarr[i + 5] == 't' && scarr[i + 6] == 'h' && scarr[i + 7] == 'e')
                                                if (scarr[i + 1] == 'f' && scarr[i + 2] == 'n' && scarr[i + 3] == 'o' && scarr[i + 4] == 't' && scarr[i + 5] == 't' && scarr[i + 6] == 'h' && scarr[i + 7] == 'e' && scarr[i + 8] == 'n')
                                                    if (scarr[i + 9] == ' ' || scarr[i + 9] == '(') //delim10
                                                    {
                                                        string[] row = { "ifnotthen", "ifnotthen", val };
                                                        var listViewItem = new ListViewItem(row);
                                                        lvLexeme.Items.Add(listViewItem);
                                                        i += 8;
                                                    }
                                                    else
                                                    {
                                                        string[] row = { "ifnotthen", "", inval };
                                                        var listViewItem = new ListViewItem(row);
                                                        //lvLexeme.Items.Add(listViewItem);
                                                        rtbxerrorlist.Text += "Lexical Error: 'ifnotthen' - invalid look ahead '" + scarr[i + 9] + "'\n";
                                                        i += 8;
                                                    }
                                                else
                                                {
                                                    string[] row = { "ifnotthe", "", inval };
                                                    var listViewItem = new ListViewItem(row);
                                                    //lvLexeme.Items.Add(listViewItem);
                                                    rtbxerrorlist.Text += "Lexical Error: 'ifnotthe' - invalid reserved word\n";
                                                    i += 7;
                                                }
                                            else
                                            {
                                                string[] row = { "ifnotth", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'ifnotth' - invalid reserved word\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "ifnott", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'ifnott' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    //////
                                    else
                                    {
                                        string[] row = { "ifnot", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'ifnot' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "ifno", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'ifno' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "ifn", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'ifn' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "if", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'if' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "i", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'i' - invalid reserved word\n";
                    }

                else if (scarr[i] == 'm')
                    if (scarr[i + 1] == 'a')
                        if (scarr[i + 1] == 'a' && scarr[i + 2] == 'r')
                            if (scarr[i + 1] == 'a' && scarr[i + 2] == 'r' && scarr[i + 3] == 'k')
                                if (scarr[i + 4] == ':') //colon
                                {
                                    string[] row = { "mark", "mark", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += 3;
                                }
                                else
                                {
                                    string[] row = { "mark", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'mark' - invalid look ahead '" + scarr[i + 4] + "'\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "mar", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'mar' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "ma", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'ma' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "m", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'm' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'n')
                    if (scarr[i + 1] == 'u')
                        if (scarr[i + 1] == 'u' && scarr[i + 2] == 'm')
                            if (scarr[i + 3] == ' ') //space
                            {
                                string[] row = { "num", "num", val };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += 2;
                            }
                            else
                            {
                                string[] row = { "num", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'num' - invalid look ahead '" + scarr[i + 3] + "'\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "nu", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'nu' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "n", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'n' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'o')
                    if (scarr[i + 1] == 'n')
                        if (scarr[i + 1] == 'n' && scarr[i + 2] == 'c')
                            if (scarr[i + 1] == 'n' && scarr[i + 2] == 'c' && scarr[i + 3] == 'e')
                                if (scarr[i + 4] == ' ' && scarr[i + 4] == '(') //delim10
                                {
                                    string[] row = { "once", "once", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += 3;
                                }
                                else
                                {
                                    string[] row = { "once", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'once' - invalid look ahead '" + scarr[i + 4] + "'\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "onc", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'onc' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "on", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'on' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "o", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'o' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'p')
                    if (scarr[i + 1] == 'r')
                        if (scarr[i + 1] == 'r' && scarr[i + 2] == 'o')
                            if (scarr[i + 1] == 'r' && scarr[i + 2] == 'o' && scarr[i + 3] == 'l')
                                if (scarr[i + 1] == 'r' && scarr[i + 2] == 'o' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o')
                                    if (scarr[i + 1] == 'r' && scarr[i + 2] == 'o' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o' && scarr[i + 5] == 'g')
                                        if (scarr[i + 1] == 'r' && scarr[i + 2] == 'o' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o' && scarr[i + 5] == 'g' && scarr[i + 6] == 'u')
                                            if (scarr[i + 1] == 'r' && scarr[i + 2] == 'o' && scarr[i + 3] == 'l' && scarr[i + 4] == 'o' && scarr[i + 5] == 'g' && scarr[i + 6] == 'u' && scarr[i + 7] == 'e')
                                                if (scarr[i + 8] == '\n')//enter
                                                {
                                                    string[] row = { "prologue", "prologue", val };
                                                    var listViewItem = new ListViewItem(row);
                                                    lvLexeme.Items.Add(listViewItem);
                                                    i += 7;
                                                }
                                                else
                                                {
                                                    string[] row = { "prologue", "", inval };
                                                    var listViewItem = new ListViewItem(row);
                                                    //lvLexeme.Items.Add(listViewItem);
                                                    rtbxerrorlist.Text += "Lexical Error: 'prologue' - invalid look ahead '" + scarr[i + 8] + "'\n";
                                                    i += 7;
                                                }
                                            else
                                            {
                                                string[] row = { "prologu", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'prologu' - invalid reserved word\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "prolog", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'prolog' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "prolo", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'prolo' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "prol", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'prol' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "pro", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'pro' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "pr", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'pr' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "p", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'p' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'r')
                    if (scarr[i + 1] == 'e')
                        if (scarr[i + 1] == 'e' && scarr[i + 2] == 'a')
                            if (scarr[i + 1] == 'e' && scarr[i + 2] == 'a' && scarr[i + 3] == 'l')
                                if (scarr[i + 1] == 'e' && scarr[i + 2] == 'a' && scarr[i + 3] == 'l' && scarr[i + 4] == 'i')
                                    if (scarr[i + 1] == 'e' && scarr[i + 2] == 'a' && scarr[i + 3] == 'l' && scarr[i + 4] == 'i' && scarr[i + 5] == 't')
                                        if (scarr[i + 1] == 'e' && scarr[i + 2] == 'a' && scarr[i + 3] == 'l' && scarr[i + 4] == 'i' && scarr[i + 5] == 't' && scarr[i + 6] == 'y')
                                            if (scarr[i + 7] == ' ' || scarr[i + 7] == ':' || scarr[i + 7] == ',' || scarr[i + 7] == ')') //delim20
                                            {
                                                string[] row = { "reality", "reality", val };
                                                var listViewItem = new ListViewItem(row);
                                                lvLexeme.Items.Add(listViewItem);
                                                i += 6;
                                            }
                                            else
                                            {
                                                string[] row = { "reality", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'reality' - invalid look ahead '" + scarr[i + 7] + "'\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "realit", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'realit' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "reali", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'reali' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "real", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'real' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "rea", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'rea' - invalid reserved word\n";
                                i += 2;
                            }
                        else if (scarr[i + 1] == 'e' && scarr[i + 2] == 'q')
                            if (scarr[i + 1] == 'e' && scarr[i + 2] == 'q' && scarr[i + 3] == 'u')
                                if (scarr[i + 1] == 'e' && scarr[i + 2] == 'q' && scarr[i + 3] == 'u' && scarr[i + 4] == 'e')
                                    if (scarr[i + 1] == 'e' && scarr[i + 2] == 'q' && scarr[i + 3] == 'u' && scarr[i + 4] == 'e' && scarr[i + 5] == 's')
                                        if (scarr[i + 1] == 'e' && scarr[i + 2] == 'q' && scarr[i + 3] == 'u' && scarr[i + 4] == 'e' && scarr[i + 5] == 's' && scarr[i + 6] == 't')
                                            if (scarr[i + 7] == ' ' || scarr[i + 7] == '>') //delim31
                                            {
                                                string[] row = { "request", "request", val };
                                                var listViewItem = new ListViewItem(row);
                                                lvLexeme.Items.Add(listViewItem);
                                                i += 6;
                                            }
                                            else
                                            {
                                                string[] row = { "request", "", inval };
                                                var listViewItem = new ListViewItem(row);
                                                //lvLexeme.Items.Add(listViewItem);
                                                rtbxerrorlist.Text += "Lexical Error: 'request' - invalid look ahead '" + scarr[i + 7] + "'\n";
                                                i += 6;
                                            }
                                        else
                                        {
                                            string[] row = { "reques", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'reques' - invalid reserved word\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "reque", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'reque' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "requ", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'requ' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "req", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'req' - invalid reserved word\n";
                                i += 2;
                            }
                        else if (scarr[i + 1] == 'e' && scarr[i + 2] == 't')
                            if (scarr[i + 1] == 'e' && scarr[i + 2] == 't' && scarr[i + 3] == 'u')
                                if (scarr[i + 1] == 'e' && scarr[i + 2] == 't' && scarr[i + 3] == 'u' && scarr[i + 4] == 'r')
                                    if (scarr[i + 1] == 'e' && scarr[i + 2] == 't' && scarr[i + 3] == 'u' && scarr[i + 4] == 'r' && scarr[i + 5] == 'n')
                                        if (scarr[i + 6] == ' ') //space
                                        {
                                            string[] row = { "return", "return", val };
                                            var listViewItem = new ListViewItem(row);
                                            lvLexeme.Items.Add(listViewItem);
                                            i += 5;
                                        }
                                        else
                                        {
                                            string[] row = { "return", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'return' - invalid look ahead '" + scarr[i + 6] + "'\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "retur", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'retur' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "retu", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'retu' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "ret", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'ret' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "re", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 're' - invalid reserved word\n";
                            i += 1;
                        }

                    else if (scarr[i + 1] == 'u')
                        if (scarr[i + 1] == 'u' && scarr[i + 2] == 'n')
                            if (scarr[i + 3] == ' ' || scarr[i + 3] == '[') //delim14
                            {
                                string[] row = { "run", "run", val };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += 2;
                            }
                            else
                            {
                                string[] row = { "run", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'run' - invalid look ahead '" + scarr[i + 3] + "'\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "ru", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'ru' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "r", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'r' - invalid reserved word\n";
                    }

                else if (scarr[i] == 's')
                    if (scarr[i + 1] == 'h')
                        if (scarr[i + 1] == 'h' && scarr[i + 2] == 'e')
                            if (scarr[i + 1] == 'h' && scarr[i + 2] == 'e' && scarr[i + 3] == 'l')
                                if (scarr[i + 1] == 'h' && scarr[i + 2] == 'e' && scarr[i + 3] == 'l' && scarr[i + 4] == 'f')
                                    if (scarr[i + 5] == ' ') //space
                                    {
                                        string[] row = { "shelf", "shelf", val };
                                        var listViewItem = new ListViewItem(row);
                                        lvLexeme.Items.Add(listViewItem);
                                        i += 4;
                                    }
                                    else
                                    {
                                        string[] row = { "shelf", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'shelf' - invalid look ahead '" + scarr[i + 5] + "'\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "shel", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'shel' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "she", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'she' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "sh", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'sh' - invalid reserved word\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == 'w')
                        if (scarr[i + 1] == 'w' && scarr[i + 2] == 'i')
                            if (scarr[i + 1] == 'w' && scarr[i + 2] == 'i' && scarr[i + 3] == 't')
                                if (scarr[i + 1] == 'w' && scarr[i + 2] == 'i' && scarr[i + 3] == 't' && scarr[i + 4] == 'c')
                                    if (scarr[i + 1] == 'w' && scarr[i + 2] == 'i' && scarr[i + 3] == 't' && scarr[i + 4] == 'c' && scarr[i + 5] == 'h')
                                        if (scarr[i + 6] == ' ' || scarr[i + 6] == '(') //delim10
                                        {
                                            string[] row = { "switch", "switch", val };
                                            var listViewItem = new ListViewItem(row);
                                            lvLexeme.Items.Add(listViewItem);
                                            i += 5;
                                        }
                                        else
                                        {
                                            string[] row = { "switch", "", inval };
                                            var listViewItem = new ListViewItem(row);
                                            //lvLexeme.Items.Add(listViewItem);
                                            rtbxerrorlist.Text += "Lexical Error: 'switch' - invalid look ahead '" + scarr[i + 6] + "'\n";
                                            i += 5;
                                        }
                                    else
                                    {
                                        string[] row = { "switc", "", inval };
                                        var listViewItem = new ListViewItem(row);
                                        //lvLexeme.Items.Add(listViewItem);
                                        rtbxerrorlist.Text += "Lexical Error: 'switc' - invalid reserved word\n";
                                        i += 4;
                                    }
                                else
                                {
                                    string[] row = { "swit", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'swit' - invalid reserved word\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "swi", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'swi' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "sw", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'sw' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "s", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 's' - invalid reserved word\n";
                    }

                else if (scarr[i] == 'u')
                    if (scarr[i + 1] == 'p')
                        if (scarr[i + 1] == 'p' && scarr[i + 2] == 't')
                            if (scarr[i + 1] == 'p' && scarr[i + 2] == 't' && scarr[i + 3] == 'o')
                                if (scarr[i + 4] == ' ' && scarr[i + 4] == '(') //delim10
                                {
                                    string[] row = { "upto", "upto", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += 3;
                                }
                                else
                                {
                                    string[] row = { "upto", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'upto' - invalid look ahead '" + scarr[i + 4] + "'\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "upt", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'upt' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "up", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'up' - invalid reserved word\n";
                            i += 1;
                        }

                    else if (scarr[i + 1] == 's')
                        if (scarr[i + 1] == 's' && scarr[i + 2] == 'e')
                            if (scarr[i + 3] == ' ') //space
                            {
                                string[] row = { "use", "use", val };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += 2;
                            }
                            else
                            {
                                string[] row = { "use", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'use' - invalid look ahead '" + scarr[i + 3] + "'\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "us", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'us' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "u", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'u' - invalid reserved word\n";
                    }
                else if (scarr[i] == 'w')
                    if (scarr[i + 1] == 'i')
                        if (scarr[i + 1] == 'i' && scarr[i + 2] == 'p')
                            if (scarr[i + 1] == 'i' && scarr[i + 2] == 'p' && scarr[i + 3] == 'e')
                                if (scarr[i + 4] == ':') //colon
                                {
                                    string[] row = { "wipe", "wipe", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += 3;
                                }
                                else
                                {
                                    string[] row = { "wipe", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'wipe' - invalid look ahead '" + scarr[i + 4] + "'\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "wip", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'wip' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "wi", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'wi' - invalid reserved word\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == 'o')
                        if (scarr[i + 1] == 'o' && scarr[i + 2] == 'r')
                            if (scarr[i + 1] == 'o' && scarr[i + 2] == 'r' && scarr[i + 3] == 'd')
                                if (scarr[i + 4] == ' ') //space
                                {
                                    string[] row = { "word", "word", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += 3;
                                }
                                else
                                {
                                    string[] row = { "word", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: 'word' - invalid look ahead '" + scarr[i + 4] + "'\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { "wor", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: 'wor' - invalid reserved word\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { "wo", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: 'wo' - invalid reserved word\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "w", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: 'w' - invalid reserved word\n";
                    }

                #endregion
                #region SYMBOLS
                else if (scarr[i] == '+')// addition
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || scarr[i + 1] == '(' || scarr[i + 1] == '~' || RGnum09.IsMatch(scarr[i + 1].ToString())) //delim33 =delim15, ~
                    {
                        string[] row = { "+", "+", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '+')// increment
                        if (scarr[i + 2] == ' ' || scarr[i + 2] == ':' || scarr[i + 2] == ')') // delim16
                        {
                            string[] row = { "++", "++", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "++", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '++' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                            
                        }
                    else if (scarr[i + 1] == '=')// assignment
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { "+=", "+=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "+=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '+=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "+", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '+' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '-')// subtraction
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || scarr[i + 1] == '(' || scarr[i + 1] == '~' || RGnum09.IsMatch(scarr[i + 1].ToString())) //delim33 =delim15, ~
                    {
                        string[] row = { "-", "-", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// assignment
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { "-=", "-=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "-=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '-=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == '-')// decrement
                        if (scarr[i + 2] == ' ' || scarr[i + 2] == ':' || scarr[i + 2] == ')') // delim16
                        {
                            string[] row = { "--", "--", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "--", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '--' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "-", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '-' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '*')// multiplication
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || scarr[i + 1] == '(' || scarr[i + 1] == '~' || RGnum09.IsMatch(scarr[i + 1].ToString())) //delim33 =delim15, ~
                    {
                        string[] row = { "*", "*", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// assignment
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { "*=", "*=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "*=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '*=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "*", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '*' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '/')// division
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || scarr[i + 1] == '(' || scarr[i + 1] == '~' || RGnum09.IsMatch(scarr[i + 1].ToString())) //delim33 = delim15, ~
                    {
                        string[] row = { "/", "/", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// assignment
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { "/=", "/=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "/=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '/=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "/", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '/' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '%')// module
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || scarr[i + 1] == '(' || scarr[i + 1] == '~' || RGnum09.IsMatch(scarr[i + 1].ToString())) // delim33 = delim15, ~
                    {
                        string[] row = { "%", "%", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// assignment
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { "%=", "%=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "%=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '%=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "%", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '%' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '^')// exponent
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || scarr[i + 1] == '(' || RGnum09.IsMatch(scarr[i + 1].ToString()))// delim15
                    {
                        string[] row = { "^", "^", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else
                    {
                        string[] row = { "^", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '^' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '~')// negative
                    if (scarr[i + 1] == '@' || scarr[i + 1] == '(' || RGnum09.IsMatch(scarr[i + 1].ToString())) // delim34
                    {
                        string[] row = { "~", "~", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else
                    {
                        string[] row = { "~", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '~' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '<')// less than
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || RGnum09.IsMatch(scarr[i + 1].ToString()))// delim19
                    {
                        string[] row = { "<", "<", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// or equal
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { "<=", "<=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "<=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '<=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == '-')   ////////////COMMENTS
                    {
                        cmntctr = 2;
                        if (scarr[i + 1] == '-' && scarr[i + 2] == '-')
                        {
                            cmntctr += 1;
                            while ((scarr[i + cmntctr] == '-' && scarr[i + cmntctr + 1] == '-' && scarr[i + cmntctr + 2] == '>') == false && i + cmntctr < sourcecode.Length - 1)
                            {
                                cmntctr++;
                            }
                            if (i + cmntctr == sourcecode.Length - 1)
                            {
                                string[] row = { "<--", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: '<--' - expected '-->'\n";
                                i += cmntctr;
                            }
                            else
                            {
                                cmntctr += 2;
                                if (scarr[i + cmntctr + 1] == ' ')///DELIIIIIIIIM
                                {
                                    string[] row = { "<-- -->", "comment", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += cmntctr;
                                }
                                else
                                {
                                    string[] row = { "<-- -->", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: '<-- -->' - invalid look ahead '" + scarr[i + cmntctr + 1] + "'\n";
                                    i += cmntctr;
                                }
                            }
                        }
                    }
                    else if (scarr[i + 1] == '<')// output
                        if (RGnum09.IsMatch(scarr[i + 2].ToString()) || scarr[i + 2] == '@' || scarr[i + 2] == '"')// ascii .////////////////////////////////////
                        {
                            string[] row = { "<<", "<<", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "<<", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '<<' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "<", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '<' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '>')// greater than
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || RGnum09.IsMatch(scarr[i + 1].ToString()))// delim19
                    {
                        string[] row = { ">", ">", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// or equal
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { ">=", ">=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { ">=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '>=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == '>')// input
                        if (scarr[i + 2] == '@')// identifier
                        {
                            string[] row = { ">>", ">>", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { ">>", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '>>' - expected '@' identifier + '\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { ">", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '>' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '&')
                    if (scarr[i + 1] == '&')// AND
                        if (scarr[i + 2] == ' ')// space
                        {
                            string[] row = { "&&", "&&", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "&&", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '&&' - expected 'space' for separation\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "&", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '&' - expected '&'\n";
                    }
                else if (scarr[i] == '|')
                    if (scarr[i + 1] == '|')// OR
                        if (scarr[i + 2] == ' ')// space
                        {
                            string[] row = { "||", "||", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "||", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '||' - expected 'space' for separation\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "|", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '|' - expected '|'\n";
                    }
                else if (scarr[i] == '!')// negation    //////////////////////////////////////////////////////////////////
                    if (scarr[i + 1] == '@')// delim19
                    {
                        string[] row = { "!", "!", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// not equal
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim19
                        {
                            string[] row = { "!=", "!=", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "!=", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '!=' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == '+')// access
                        if (scarr[i + 2] == ' ')// space        ///////////////////////////////////////////////////////////////
                        {
                            string[] row = { "!+", "!+", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "!+", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '!+' - expected 'space' for separation'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "!", "", val };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '!' - expected '@', '=' or '+'\n";
                    }
                else if (scarr[i] == '=')// declarational equal
                    if (scarr[i + 1] == '"' || scarr[i + 1] == '(' || scarr[i + 1] == '{' || scarr[i + 1] == ' ' || scarr[i + 1] == '@' || RGnum09.IsMatch(scarr[i + 1].ToString())) // delim 22 { delim21,  “ , ( , { }
                    {
                        string[] row = { "=", "=", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '=')// conditional equal
                        if (scarr[i + 2] == '@' || scarr[i + 2] == ' ' || RGnum09.IsMatch(scarr[i + 2].ToString()))// delim21
                        {
                            string[] row = { "==", "==", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "==", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '==' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "=", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '=' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == ':')
                    if (scarr[i + 1] == ':')// terminator
                        if (scarr[i + 2] == ' ' || scarr[i + 2] == '@' || scarr[i + 2] == '\n')// delim18////////////////////////////////////////////////////
                        {
                            string[] row = { "::", "::", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "::", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '::' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else if (scarr[i + 1] == 'n')
                        if (scarr[i + 1] == 'n' && scarr[i + 2] == 't')
                            if (scarr[i + 1] == 'n' && scarr[i + 2] == 't' && scarr[i + 3] == 'r')// next line
                                if (RGascii.IsMatch(scarr[i + 4].ToString()))// ascii////////////////////////////////////////////////
                                {
                                    string[] row = { ":ntr", ":ntr", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += 3;
                                }
                                else
                                {
                                    string[] row = { ":ntr", "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    //lvLexeme.Items.Add(listViewItem);
                                    rtbxerrorlist.Text += "Lexical Error: ':ntr' - invalid look ahead '" + scarr[i + 4] + "'\n";
                                    i += 3;
                                }
                            else
                            {
                                string[] row = { ":nt", "", inval };
                                var listViewItem = new ListViewItem(row);
                                //lvLexeme.Items.Add(listViewItem);
                                rtbxerrorlist.Text += "Lexical Error: ':nt' - invalid symbol\n";
                                i += 2;
                            }
                        else
                        {
                            string[] row = { ":n", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: ':n' - invalid symbol\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { ":", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: ':' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == ',')// separator
                    if (scarr[i + 1] == ' ' || scarr[i + 1] == '@')// delim18
                    {
                        string[] row = { ",", ",", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else
                    {
                        string[] row = { ",", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: ',' - expected 'space' or '@' identifier\n";
                    }
                else if (scarr[i] == '(')
                    if (scarr[i + 1] == '@' || scarr[i + 1] == ' ' || scarr[i + 1] == ')' || RGnum09.IsMatch(scarr[i + 1].ToString()))// delim19
                    {
                        string[] row = { "(", "(", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else
                    {
                        string[] row = { "(", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '(' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == ')')
                    if (scarr[i + 1] == ' ' || scarr[i + 1] == ':' || scarr[i + decctr] == '+' || scarr[i + decctr] == '-' || scarr[i + decctr] == '*' || scarr[i + decctr] == '/' || scarr[i + decctr] == '%' || scarr[i + decctr] == '^' || scarr[i + decctr] == '\n')// delim23 = delim13{space, colon}, mathop=+ , - , * , / ,%,^
                    {
                        string[] row = { ")", ")", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem); 
                    }
                    else
                    {
                        string[] row = { ")", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: ')' - expected 'space', 'colon' or 'mathop'\n";
                    }
                //else if (scarr[i] == '"')       /////////////////////////////////////////////////////////CHECK STRING LITERALS
                //    //if (scarr[i + || scarr[i + strctr + 1] == '<' || scarr[i + strctr + 1] == '=' || scarr[i + strctr + 1] == '&' || scarr[i + strctr + 1] == '|' || scarr[i + strctr + 1] == '!')// colon, ,, <, =, logop=& ,| ,! 
                //        if (scarr[i + 1] == ',' || scarr[i + 1] == ':' || scarr[i + decctr] == '}')// delim24
                //        rtbxleximcheck.Text += (val + '\n');
                //    else
                //    {
                //        rtbxleximcheck.Text += (inval + '\n');
                //    }
                else if (scarr[i] == '[')
                    if (scarr[i + 1] == '@' || RGnum19.IsMatch(scarr[i + 1].ToString()))// delim24
                    {
                        string[] row = { "[", "[", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == '[')
                        if (scarr[i + 2] == ' ' || scarr[i + 2] == '@' || scarr[i + 2] == '\n' || RGalp.IsMatch(scarr[i + 2].ToString()))// delim38 = delim25{delim18, alpha}, next line
                        {
                            string[] row = { "[[", "[[", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "[[", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '[[' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "[", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '[' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == ']')
                    if (scarr[i + 1] == ',' || scarr[i + 1] == ':')// delim1
                    {
                        string[] row = { "]", "]", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else if (scarr[i + 1] == ']')// space
                        if (scarr[i + 2] == ' ')
                        {
                            string[] row = { "]]", "]]", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { "]]", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: ']]' - expected 'space' for separation\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { "]", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: ']' - invalid look ahead '" + scarr[i + 1] + "'\n";
                    }
                else if (scarr[i] == '{')
                    if (scarr[i + 1] == '"' || RGnum09.IsMatch(scarr[i + 1].ToString()))// delim26
                    {
                        string[] row = { "{", "{", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else
                    {
                        string[] row = { "{", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '{' - expected 'single quotation mark' or 'numbers ranges from 0 to 9'\n";
                    }
                else if (scarr[i] == '}')
                    if (scarr[i + 1] == ',' || scarr[i + 1] == ':')// delim1
                    {
                        string[] row = { "}", "}", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else
                    {
                        string[] row = { "}", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '}' - expected ',' or ':'\n";
                    }
                else if (scarr[i] == '.')
                    if (scarr[i + 1] == '+')
                        if (scarr[i + 2] == ' ' || scarr[i + 2] == '@' || scarr[i + 2] == '"')// delim27
                        {
                            string[] row = { ".+", ".+", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += 1;
                        }
                        else
                        {
                            string[] row = { ".+", "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '.+' - invalid look ahead '" + scarr[i + 2] + "'\n";
                            i += 1;
                        }
                    else
                    {
                        string[] row = { ".", "", inval };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '.' - expected '.'\n";
                    }
                else if (scarr[i] == ';')
                    if (scarr[i + 1] == ' ' || RGalp.IsMatch(scarr[i + 1].ToString()))// delim2
                    {
                        string[] row = { ";", ";", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                    }
                    else
                    {
                        string[] row = { ";", "", inval };
                        var listViewItem = new ListViewItem(row);
                        rtbxerrorlist.Text += "Lexical Error: ']' - expected 'space' or 'alpha'\n";
                    }

                #endregion
                #region IDENTIFIERS
                else if (scarr[i] == '@')
                    if (RGalp.IsMatch(scarr[i + 1].ToString()))
                    {
                        idenstr = scarr[i + 1].ToString();
                        idenctr = 2;
                        while (RGalpnum.IsMatch(scarr[i + idenctr].ToString()) && idenctr < 8)
                        {
                            idenstr = idenstr + scarr[i + idenctr].ToString();
                            idenctr++;
                        }
                        if (scarr[i + idenctr] == '+' || scarr[i + idenctr] == '-' || scarr[i + idenctr] == '*' || scarr[i + idenctr] == '/' || scarr[i + idenctr] == '%' || scarr[i + idenctr] == '^' || scarr[i + idenctr] == ',' || scarr[i + idenctr] == ':' || scarr[i + idenctr] == '<' || scarr[i + idenctr] == '>' || scarr[i + idenctr] == '=' || scarr[i + idenctr] == '!' || scarr[i + idenctr] == '[' || scarr[i + idenctr] == ']' || scarr[i + idenctr] == ' ' || scarr[i + idenctr] == '(' || scarr[i + idenctr] == ')' ) //delim 29= mathop=+ , - , * , / ,%,^, delim1= , , colon , Relo=> , <, =, !, [, ] ,space
                        {
                            string[] row = { "@" + idenstr, "id", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += idenctr - 1;
                        }
                        else
                        {
                            string[] row = { "@" + idenstr, "", inval };
                            var listViewItem = new ListViewItem(row);
                            //lvLexeme.Items.Add(listViewItem);
                            rtbxerrorlist.Text += "Lexical Error: '@" + idenstr + "' - invalid look ahead '" + scarr[i + idenctr] +"'\n";
                            i += idenctr - 1;
                        }
                    }
                    else
                    {
                        string[] row = { "@", "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: '@' - expected alpha character\n";
                    }
                #endregion
                #region LITERALS
                ////INT & FLOAT LITERALS
                #region FloatLit (0)
                //////FLOAT LITERAL if 0 ung umpisa
                else if (scarr[i] == '0')
                {
                    decstr = scarr[i].ToString();
                    decctr = 1;
                    while (RGnum09.IsMatch(scarr[i + decctr].ToString()) && decctr < 9)
                    {
                        decstr += scarr[i + decctr].ToString();
                        decctr++;
                    }
                    if (scarr[i + decctr] == '.')
                    {
                        decstr += scarr[i + decctr].ToString();
                        decctr++;
                        if (RGnum09.IsMatch(scarr[i + decctr].ToString()))
                        {
                            decstr += scarr[i + decctr].ToString();
                            decctr++;
                            if (scarr[i + decctr] == '+' || scarr[i + decctr] == '-' || scarr[i + decctr] == '*' || scarr[i + decctr] == '/' || scarr[i + decctr] == '%' || scarr[i + decctr] == '^' || scarr[i + decctr] == '&' || scarr[i + decctr] == '|' || scarr[i + decctr] == '!' || scarr[i + decctr] == ',' || scarr[i + decctr] == ':' || scarr[i + decctr] == ')') // delim36= mathop=+ , - , * , / ,%,^, logop=& ,| ,! , , , :, )
                            {
                                string[] row = { decstr, "declit", val };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += decctr - 1;
                            }
                            else if (RGnum09.IsMatch(scarr[i + decctr].ToString()))
                            {
                                decstr += scarr[i + decctr].ToString();
                                decctr++;
                                if (scarr[i + decctr] == '+' || scarr[i + decctr] == '-' || scarr[i + decctr] == '*' || scarr[i + decctr] == '/' || scarr[i + decctr] == '%' || scarr[i + decctr] == '^' || scarr[i + decctr] == '&' || scarr[i + decctr] == '|' || scarr[i + decctr] == '!' || scarr[i + decctr] == ',' || scarr[i + decctr] == ':' || scarr[i + decctr] == ')') // delim36= mathop=+ , - , * , / ,%,^, logop=& ,| ,! , , , :, )
                                {
                                    string[] row = { decstr, "declit", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += decctr - 1;
                                }
                                else
                                {
                                    string[] row = { decstr, "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += decctr - 1;
                                }
                            }
                            else
                            {
                                string[] row = { decstr, "", inval };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += decctr - 1;
                            }
                        }
                        else
                        {
                            string[] row = { decstr, "", inval };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += decctr - 1;
                        }
                    }

                    else
                    {
                        string[] row = { decstr, "", inval };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                        i += decctr - 1;
                    }
                }
                #endregion
                else if (RGnum19.IsMatch(scarr[i].ToString()))
                {
                    numstr = scarr[i].ToString(); decstr = scarr[i].ToString();
                    numctr = 1; decctr = 1;
                    while (RGnum09.IsMatch(scarr[i + numctr].ToString()) && numctr < 9)
                    {
                        numstr += scarr[i+numctr].ToString(); decstr += scarr[i + decctr].ToString();
                        numctr++; decctr++;
                    }
                    #region  INTEGER LITERAL
                    if (scarr[i + numctr] == '+' || scarr[i + numctr] == '-' || scarr[i + numctr] == '*' || scarr[i + numctr] == '/' || scarr[i + numctr] == '%' || scarr[i + numctr] == '^' || scarr[i + numctr] == '<' || scarr[i + numctr] == '>' || scarr[i + numctr] == '=' || scarr[i + numctr] == '!' || scarr[i + numctr] == '&' || scarr[i + numctr] == '|' || scarr[i + numctr] == '!' || scarr[i + numctr] == ',' || scarr[i + numctr] == ':' || scarr[i + numctr] == ']' || scarr[i + numctr] == ')')//delim35= mathop, relop, logop, ,, :, ], ) 
                    {
                        string[] row = { numstr, "numlit", val };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                        i += numctr - 1;
                    }

                    #endregion
                    #region FLOAT LITERAL (1-9)
                    else if (scarr[i + decctr] == '.')
                    {
                        decstr += scarr[i + decctr].ToString();
                        decctr++;
                        if (RGnum09.IsMatch(scarr[i + decctr].ToString()))
                        {
                            decstr += scarr[i + decctr].ToString();
                            decctr++;
                            if (scarr[i + decctr] == '+' || scarr[i + decctr] == '-' || scarr[i + decctr] == '*' || scarr[i + decctr] == '/' || scarr[i + decctr] == '%' || scarr[i + decctr] == '^' || scarr[i + decctr] == '&' || scarr[i + decctr] == '|' || scarr[i + decctr] == '!' || scarr[i + decctr] == ',' || scarr[i + decctr] == ':' || scarr[i + decctr] == ')') // delim36= mathop=+ , - , * , / ,%,^, logop=& ,| ,! , , , :, )
                            {
                                string[] row = { decstr, "declit", val };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += decctr - 1;
                            }
                            else if (RGnum09.IsMatch(scarr[i + decctr].ToString()))
                            {
                                decstr += scarr[i + decctr].ToString();
                                decctr++;
                                if (scarr[i + decctr] == '+' || scarr[i + decctr] == '-' || scarr[i + decctr] == '*' || scarr[i + decctr] == '/' || scarr[i + decctr] == '%' || scarr[i + decctr] == '^' || scarr[i + decctr] == '&' || scarr[i + decctr] == '|' || scarr[i + decctr] == '!' || scarr[i + decctr] == ',' || scarr[i + decctr] == ':' || scarr[i + decctr] == ')') // delim36= mathop=+ , - , * , / ,%,^, logop=& ,| ,! , , , :, )
                                {
                                    string[] row = { decstr, "declit", val };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += decctr - 1;
                                }
                                else
                                {
                                    string[] row = { decstr, "", inval };
                                    var listViewItem = new ListViewItem(row);
                                    lvLexeme.Items.Add(listViewItem);
                                    i += decctr - 1;
                                }
                            }
                            else
                            {
                                string[] row = { decstr, "", inval };
                                var listViewItem = new ListViewItem(row);
                                lvLexeme.Items.Add(listViewItem);
                                i += decctr - 1;
                            }
                        }
                        else
                        {
                            string[] row = { decstr, "", inval };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += decctr - 1;
                        }
                    }
                    else
                    {
                        string[] row = { numstr, "", inval };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                        i += numctr - 1;
                    }
                    #endregion
                }
                ////STRING LITERALS
                else if (scarr[i] == '"')
                {
                    strstr = scarr[i].ToString();
                    strctr = 1;
                    while (scarr[i + strctr] != '"' && i + strctr < sourcecode.Length - 1)
                    {
                        strstr += scarr[i + strctr].ToString();
                        strctr++;
                    }
                    if (i + strctr == sourcecode.Length - 1)
                    {
                        string[] row = { strstr, "", inval };
                        var listViewItem = new ListViewItem(row);
                        lvLexeme.Items.Add(listViewItem);
                        i += strctr;
                    }
                    else
                    {
                        if (scarr[i + strctr + 1] == ':' || scarr[i + strctr + 1] == ',' || scarr[i + strctr + 1] == '<' || scarr[i + strctr + 1] == '=' || scarr[i + strctr + 1] == '&' || scarr[i + strctr + 1] == '|' || scarr[i + strctr + 1] == '!')// colon, ,, <, =, logop=& ,| ,! 
                        {
                            string[] row = { strstr+"\"", "wordlit", val };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += strctr;
                        }
                        else
                        {
                            string[] row = { strstr+"\"", "", inval };
                            var listViewItem = new ListViewItem(row);
                            lvLexeme.Items.Add(listViewItem);
                            i += strctr;
                        }
                    }
                }
                #endregion

                else
                {
                    if (scarr[i] == '\n' || scarr[i] == ' ')
                    { }
                    else
                    {
                        string[] row = { scarr[i].ToString(), "", inval };
                        var listViewItem = new ListViewItem(row);
                        //lvLexeme.Items.Add(listViewItem);
                        rtbxerrorlist.Text += "Lexical Error: " + scarr[i] + " - invalid\n";
                    }
                }


                i += 1;//ESSENTIAAAAAAL~!!!!!
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            rtbxleximcheck.Clear();
            lvLexeme.Items.Clear();
            rtbxerrorlist.Clear();
            lexicalcheck();
        }

        private void rtbxNotepad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // || e.KeyCode == Keys.Space )
            {
                rtbxleximcheck.Clear();
                lvLexeme.Items.Clear();
                rtbxerrorlist.Clear();
                lexicalcheck();
                
            }
        }

        #region ScrollBar
        public enum ScrollBarType : uint
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }

        public enum Message : uint
        {
            WM_VSCROLL = 0x0115
        }

        public enum ScrollBarCommands : uint
        {
            SB_THUMBPOSITION = 4
        }

        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        private void rtbxNotepad_VScroll(object sender, EventArgs e)
        {
            int nPos = GetScrollPos(rtbxNotepad.Handle, (int)ScrollBarType.SbVert);
            nPos <<= 16;
            uint wParam = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)nPos;
            SendMessage(rtbxleximcheck.Handle, (int)Message.WM_VSCROLL, new IntPtr(wParam), new IntPtr(0));
        }

        private void rtbxleximcheck_VScroll(object sender, EventArgs e)
        {
            //    int nPos = GetScrollPos(rtbxleximcheck.Handle, (int)ScrollBarType.SbVert);
            //    nPos <<= 16;
            //    uint wParam = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)nPos;
            //    SendMessage(rtbxNotepad.Handle, (int)Message.WM_VSCROLL, new IntPtr(wParam), new IntPtr(0));
        }
        #endregion
    }
}
