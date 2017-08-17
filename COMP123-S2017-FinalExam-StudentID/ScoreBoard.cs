using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{/// <summary>
/// This class is called ScoreBoard.
/// </summary>
    class ScoreBoard
    {
        // PRIVATE FIELDS (Instance Variables)----------------------
        TextBox _finalScoreTextBox;
        int _score;
        TextBox _scoreTextBox;
        int _time;
        TextBox _timeTextBox;

        // PUBLIC PROPERTIES ----------------------------------------
        /// <summary>
        /// These are the five public properties of this class
        /// </summary>
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }

        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                ScoreTextBox.Text = Convert.ToString(this._score);
                FinalScoreTextBox.Text = Convert.ToString(this._score);
                
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                TimeTextBox.Text = Convert.ToString(_time);
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox=value;
            }
        }

    }
}
