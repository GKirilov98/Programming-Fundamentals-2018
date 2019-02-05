using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            // за сортирането според броя участници трябва да е - foreach (var id in db.OrderByDescending(x => x.Value.Values.Distinct().Sum(y => y.Count))) ... но това дава само 40/100, аз реших задачата с класове 
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string line = Console.ReadLine();
            while (line != "course start")
            {
                if (line != string.Empty) {
                    string[] tokens = line.Trim().Split(':', StringSplitOptions.RemoveEmptyEntries);
                    switch (tokens[0])
                    {
                        case "Add":
                            AddLesson(lessons, tokens);
                            break;
                        case "Insert":
                            InsertLesson(lessons, tokens);
                            break;
                        case "Remove":
                            RemoveLessonExercise(lessons, tokens);
                            break;
                        case "Swap":
                            SwapLessons(lessons, tokens);
                            break;
                        case "Exercise":
                            Exercise(lessons, tokens);
                            break;
                    }
                }
                line = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        private static void Exercise(List<string> lessons, string[] tokens)
        {
            if (tokens.Count() == 2)
            {
                string lessonExercise = tokens[1].Trim() + "-Exercise";
                string lessonTitle = tokens[1].Trim();

                if (lessons.Contains(lessonTitle))
                {
                    
                }
                else
                {
                    lessons.Add(lessonTitle);
                }

                if (lessons.Contains(lessonExercise) == false)
                {
                    lessons.Insert(lessons.IndexOf(lessonTitle) + 1, lessonExercise);
                }

            }
        }

        private static void SwapLessons(List<string> lessons, string[] tokens)
        {
            if (tokens.Count() == 3)
            {

                string firstLessonTitle = tokens[1].Trim();
                string secondLessonTitle = tokens[2].Trim();
                string firstExercise = tokens[1].Trim() + "-Exercise";
                string seconExercise = tokens[2].Trim() + "-Exercise";


                int insertIndexFirst = lessons.IndexOf(secondLessonTitle) + 1;
                int inserIndexSecond = lessons.IndexOf(firstLessonTitle) + 1;
                if (lessons.Contains(firstLessonTitle) && lessons.Contains(secondLessonTitle))
                {
                    int firstLessonIndex = lessons.IndexOf(firstLessonTitle);
                    int secondLessonIndex = lessons.IndexOf(secondLessonTitle);

                    lessons.RemoveAt(firstLessonIndex);
                    lessons.Insert(firstLessonIndex, secondLessonTitle);
                    lessons.RemoveAt(secondLessonIndex);
                    lessons.Insert(secondLessonIndex, firstLessonTitle);
                }

                if (lessons.Contains(firstExercise))
                {
                    int count1 = 0;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == firstExercise)
                        {
                            count1++;
                        }
                    }

                    lessons.RemoveAll(x => x.Equals(firstExercise));
                    for (int i = 0; i < count1; i++)
                    {
                        lessons.Insert(insertIndexFirst, firstExercise);
                    }
                }

                if (lessons.Contains(seconExercise))
                {
                    int count2 = 0;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == seconExercise)
                        {
                            count2++;
                        }
                    }

                    lessons.RemoveAll(x => x.Equals(seconExercise));
                    for (int i = 0; i < count2; i++)
                    {

                        lessons.Insert(inserIndexSecond + i, seconExercise);
                    }
                }
            }
        }

        private static void RemoveLessonExercise(List<string> lessons, string[] tokens)
        {
            if (tokens.Count() == 2)
            {
                string lessonTitle = tokens[1].Trim();
                string exercise = lessonTitle + "-Exercise";
                if (lessons.Contains(lessonTitle))
                {
                    lessons.RemoveAll(x => x.Equals(lessonTitle));
                }

                if (lessons.Contains(exercise))
                {
                    lessons.RemoveAll(x => x.Equals(exercise));
                }
            }
        }

        private static void InsertLesson(List<string> lessons, string[] tokens)
        {
            if (tokens.Count() == 3)
            {
                string lessonTitle = tokens[1].Trim();
                int index = int.Parse(tokens[2]);

                if (lessons.Contains(lessonTitle) == false)
                {
                    if (index >= 0 && index < lessons.Count)
                    {
                        if (index != 0 && lessons[index] == lessons[index - 1] + "-Exercise")
                        {
                            lessons.Insert(index - 1, lessonTitle);
                        }
                        else
                        {
                            lessons.Insert(index, lessonTitle);
                        }
                    }
                }
            }
        }

        private static void AddLesson(List<string> lessons, string[] tokens)
        {
            if (tokens.Count() == 2)
            {
                string lesson = tokens[1].Trim();
                if (lessons.Contains(lesson) == false)
                {
                    lessons.Add(lesson);
                }
            }
        }
    }
}
