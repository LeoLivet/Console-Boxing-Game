using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_game_H1
{
    public class MatchSettings
    {
        int _currentRound;
        int _noOfRounds;
        int _maxRounds;
        int _matchTime;
        int _maxMatchTime;
        int _currentMatch;

        bool _isMatchOnGoing;

        public MatchSettings()
        {
            _maxRounds = 3;
            _matchTime = _maxMatchTime;
            _noOfRounds = _maxRounds;
        }

        public bool IsMatchOnGoing(bool Bool)
        {
            if (Bool)
            {
                return isMatchOngoing = true;
            }
            else
            {
                return isMatchOngoing = false;
            }
        }

        public int noOfRounds
        {
            get { return _noOfRounds; }
            set { _noOfRounds = value; }
        }

        public int matchTime
        {
            get { return _matchTime; }
            set { _matchTime = value; }
        }

        public int currentMatch
        {
            get { return _currentMatch; }
            set { _currentMatch = value; }
        }

        public bool isMatchOngoing
        {
            get { return _isMatchOnGoing; }
            set { _isMatchOnGoing = value; }
        }
    }
}
