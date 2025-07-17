using Sharedd;
using System.Net.Quic;

namespace DefaultIfEmpty
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var questions = Enumerable.Empty<Question>();
            //Console.WriteLine(questions);
            //Console.WriteLine("ddddddddddd");
            //var question2 = questions.DefaultIfEmpty();
            //Console.WriteLine(question2);
            //Console.WriteLine("ddddddddddd");
            //var question3 = questions.DefaultIfEmpty(Question.Default);
            //question3.Toquize();


            //var range = Enumerable.Range(0, 10);

            //foreach (var item in range) Console.WriteLine(item);


            //int[] rangeArray = new int[10];
            //for (int i = 0; i < rangeArray.Length; i++)
            //{
            //    rangeArray[i] =i;
            //}
            //var q = QuestionBank.pickone();
            //var question = Enumerable.Repeat(q, 4);
            //question.Toquize();
            //   Console.WriteLine(question);
            // var ques = QuestionBank.All;
            //   Console.WriteLine(ques.ElementAt(10));

            ////
            //var ww=ques.First();
            //Console.WriteLine(ww);
            ////

            //var w=ques.FirstOrDefault(x=> x.Title.Length ==0);
            //Console.WriteLine(w);

            ////
            //var last = ques.Last();
            //Console.WriteLine(last);


            //  RunMethod1();
            RunMethod02();


        }

        static void RunMethod1()
        {
            //var q1 = QuestionBank.Randomize(1);
            //var q2 = QuestionBank.Randomize(2);
            //var q3= q1.Concat(q2);
            //q3.Toquize();



            //2-
            //var q01 = QuestionBank.Randomize(1);
            //var q02 = QuestionBank.Randomize(2);
            //var Qustiontitles = q01.Select(a=>a.Title).Concat(q02.Select(b=>b.Title));

            //foreach (var item in Qustiontitles)
            //{
            //    Console.WriteLine(item);
            //}



            //3-

            //var Qustiontitleess2=QuestionBank.Randomize(2)
            //    .Select(a => a.Title)
            //    .Concat(QuestionBank.Randomize(3).Select(a => a.Title))
            //    .Concat(QuestionBank.GetQuestionRange(Enumerable.Range(11,14))// 14 questions start from 11
            //    .Select(a=> a.Title));




            //foreach (var item in Qustiontitleess2)
            //    {
            //    Console.WriteLine(item);
            //}


            //4-

            var q01 = QuestionBank.Randomize(1);
            var q02 = QuestionBank.Randomize(2);
            var q03 = new[] { q01, q02 }.SelectMany(q => q);
            q03.Toquize();
        }

        static void RunMethod02()
        {
            var names = new[] { "aya", "jkld", "kdfslfk", "fdksjfkldsjf", "fdjskfsdkl" };
            //var output = "";
            //foreach (var item in names)
            //{
            //    output += $"{item},";
            //}
            //Console.WriteLine(output.TrimEnd(','));
            //var output2 = string.Join(',', names);
            //Console.WriteLine(output2);
            //--------------------------------------------------------------------------------------------------------
            //            var output3 = names.Aggregate((a, b) => $"{a},{b}");// a is accumulator , b is the result
            //            Console.WriteLine(output3);
            ////--------------------------------------------------------------------------------------------------------
            //            var nums = new[] {1,2,4,5,5 };
            //            var output4= nums.Aggregate(2,(a, b) => a+b );//0 =>is the seed=  intial val to start from it , a is accumulator , b is the result
            //            Console.WriteLine(output4);

            //--------------------------------------------------------------------------------------------------------
            //var questions = QuestionBank.All;
            //var temp = questions[124];

            //temp = questions.Aggregate(temp,
            //                          (longest, next) => longest.Title.Length < next.Title.Length ? next : longest, 
            //                           x => x);


            //Console.WriteLine( temp);
            //--------------------------------------------------------------------------------------------------------
            //var q = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            //Console.WriteLine(q.Count());
            //Console.WriteLine(q.Count(x=>x.Title.Length>200));
            //Console.WriteLine("9999999999999999");
            //Console.WriteLine(q.Where(x => x.Title.Length > 200).Count());


            //--------------------------------------------------------------------------------------------------------
            var q = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            Console.WriteLine(q.Max(x=>x.Title.Length));//262
            Console.WriteLine(q.MaxBy(x => x.Title.Length));//return question with the max ---
            //Console.WriteLine(q.Count(x => x.Title.Length > 200));
            //Console.WriteLine("9999999999999999");
            //Console.WriteLine(q.Where(x => x.Title.Length > 200).Count());
                        Console.WriteLine(q.Max(x=>x.Title.Length));//262


        }
    }
}