class NerdBank: QuestionBank
{
    //halo themed questions here- inherit and encapsulate
    public NerdBank()
    {
    Question question1 = new Question(
            "Which of these is NOT a vehicle featured in Halo?",
            new string[] {"1. Scarab", "2. Shortsword", "3. Leopard", "4. Elephant"},
            2
        );
        bank.Add(question1);

        Question question2 = new Question(
            "Who originally announced Halo to the world?",
            new string[] {"1. Bill Gates", "2. Steve Jobs", "3. Dwayne 'The Rock' Johnson"},
            1
        );
        bank.Add(question2);

        Question question3 = new Question(
            "What was the game mode called where it was Spartans vs. Elites?",
            new string[] {"1. Firefight", "2. Spartan ops", "3. War Games", "4. Spartan Assault", "5. Fireteam's", "6. Invasion"},
            5
        );
        bank.Add(question3);

        Question question4 = new Question(
            "Which Halo sold the most copies?",
            new string[] {"1. Reach", "2. Halo 2", "3. Halo 3", "4. The Master Chief Collection", "5. Halo 5"},
            2
        );
        bank.Add(question4);

        Question question5 = new Question(
            "What's the term for A.I. insanity in the Halo universe?",
            new string[] {"1. Rampancy", "2. Parity Error", "3. Glitch Overload"},
            0
        );
        bank.Add(question5);

        Question question6 = new Question(
            "How many kills do you need to earn the 'Killimanjaro' medal?",
            new string[] {"1. 4", "2. 5", "3. 6", "4. 7", "5. 8", "6. 9"},
            3
        );
        bank.Add(question6);

        Question question7 = new Question(
            "How many needles can the Needler in 'Halo 2' hold (not including the ones that have already been loaded)?",
            new string[] {"1. 40", "2. 60", "3. Infinite", "4. 180"},
            3
        );
        bank.Add(question7);

        Question question8 = new Question(
            "What is the Grunts' homeworld?",
            new string[] {"1. Requiem", "2. Bahalo", "3. Keplar", "4. Titus"},
            1
        );
        bank.Add(question8);

        Question question9 = new Question(
            "What planet do the Elites come from?",
            new string[] {"1. Requiem", "2. Helieous", "3. Te", "4. Sanghelios"},
            3
        );
        bank.Add(question9);

        Question question10 = new Question(
            "How many types of Grunts are there in Halo 3?",
            new string[] {"1. 3", "2. 4", "3. 5", "4. 7"},
            2
        );
        bank.Add(question10);

        Question question11 = new Question(
            "The Battle Rifle shoots bullets in bursts of what?",
            new string[] {"1. 1", "2. 2", "3. 3", "4. 4", "5. 5"},
            2
        );
        AddQ(question11);
    }

    // made this to reset the bank if user runs out of questions but wants a retry
    public void CompileQuestions()
    {
        Question question1 = new Question(
            "Which of these is NOT a vehicle featured in Halo?",
            new string[] {"1. Scarab", "2. Shortsword", "3. Leopard", "4. Elephant"},
            2
        );
        bank.Add(question1);

        Question question2 = new Question(
            "Who originally announced Halo to the world?",
            new string[] {"1. Bill Gates", "2. Steve Jobs", "3. Dwayne 'The Rock' Johnson"},
            0
        );
        bank.Add(question2);

        Question question3 = new Question(
            "What was the game mode called where it was Spartans vs. Elites?",
            new string[] {"1. Firefight", "2. Spartan ops", "3. War Games", "4. Spartan Assault", "5. Fireteam's", "6. Invasion"},
            5
        );
        bank.Add(question3);

        Question question4 = new Question(
            "Which Halo sold the most copies?",
            new string[] {"1. Reach", "2. Halo 2", "3. Halo 3", "4. The Master Chief Collection", "5. Halo 5"},
            2
        );
        bank.Add(question4);

        Question question5 = new Question(
            "What's the term for A.I. insanity in the Halo universe?",
            new string[] {"1. Rampancy", "2. Parity Error", "3. Glitch Overload"},
            0
        );
        bank.Add(question5);

        Question question6 = new Question(
            "How many kills do you need to earn the 'Killimanjaro' medal?",
            new string[] {"1. 4", "2. 5", "3. 6", "4. 7", "5. 8", "6. 9"},
            3
        );
        bank.Add(question6);

        Question question7 = new Question(
            "How many needles can the Needler in 'Halo 2' hold (not including the ones that have already been loaded)?",
            new string[] {"1. 40", "2. 60", "3. Infinite", "4. 180"},
            3
        );
        bank.Add(question7);

        Question question8 = new Question(
            "What is the Grunts' homeworld?",
            new string[] {"1. Requiem", "2. Bahalo", "3. Keplar", "4. Titus"},
            1
        );
        bank.Add(question8);

        Question question9 = new Question(
            "What planet do the Elites come from?",
            new string[] {"1. Requiem", "2. Helieous", "3. Te", "4. Sanghelios"},
            3
        );
        bank.Add(question9);

        Question question10 = new Question(
            "How many types of Grunts are there in Halo 3?",
            new string[] {"1. 3", "2. 4", "3. 5", "4. 7"},
            2
        );
        bank.Add(question10);

        Question question11 = new Question(
            "The Battle Rifle shoots bullets in bursts of what?",
            new string[] {"1. 1", "2. 2", "3. 3", "4. 4", "5. 5"},
            2
        );
        AddQ(question11);
    }
}