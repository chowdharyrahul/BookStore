using BookStore.Data;
using BookStore.Models;
using System.Diagnostics;

namespace BookStore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FinalContext context)
        {
            // Look for any students.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var books = new Book[]
            {
                new Book{bookName="Atomic Habits",bookType="Paperback",publishDate=DateTime.Parse("2019-09-01"),Publisher="James Clear",Language="English",Paperback="345 pages"
                ,ISBN_10=1234567891,ISBN_13=1234567890123,Item_Weight="8 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#2 in Books", CustomerReview=(float)4.8},

                new Book{bookName="Can't hurt me",bookType="Paperback",publishDate=DateTime.Parse("2019-10-01"),Publisher="Lioncrest Publishing",Language="English",Paperback="350 pages"
                ,ISBN_10=1234567800,ISBN_13=1239567890123,Item_Weight="8 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#8 in Books", CustomerReview=(float)4.8},

                new Book{bookName="Greenlights",bookType="Paperback",publishDate=DateTime.Parse("2013-09-01"),Publisher="Crown",Language="English",Paperback="380 pages"
                ,ISBN_10=1234227891,ISBN_13=1234567110123,Item_Weight="9 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#13 in Books", CustomerReview=(float)4.7},

                new Book{bookName="Life Worth Living",bookType="Paperback",publishDate=DateTime.Parse("2014-09-01"),Publisher=" The Open Field",Language="English",Paperback="320 pages"
                ,ISBN_10=1234567141,ISBN_13=4434567890123,Item_Weight="8 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#6 in Books", CustomerReview=(float)4.5},

                new Book{bookName="Outlive",bookType="Paperback",publishDate=DateTime.Parse("2005-09-01"),Publisher="Harmony",Language="English",Paperback="240 pages"
                ,ISBN_10=1234567891,ISBN_13=1234567890123,Item_Weight="6 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#1 in Books", CustomerReview=(float)4.6},

                new Book{bookName="Rich Dad Poor Dad",bookType="Paperback",publishDate=DateTime.Parse("2009-09-01"),Publisher="Plata Publishing",Language="English",Paperback="340 pages"
                ,ISBN_10=1234578991,ISBN_13=4567902438123,Item_Weight="8 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#12 in Books", CustomerReview=(float)4.7},

                new Book{bookName="Spare",bookType="Paperback",publishDate=DateTime.Parse("2009-07-01"),Publisher="Random House",Language="English",Paperback="340 pages"
                ,ISBN_10=1234567891,ISBN_13=1234567890123,Item_Weight="8 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#3 in Books", CustomerReview=(float)4.5},

                new Book{bookName="The 48 Laws of Power",bookType="Paperback",publishDate=DateTime.Parse("2011-09-21"),Publisher="Penguin Books",Language="English",Paperback="340 pages"
                ,ISBN_10=1234563471,ISBN_13=1234543890123,Item_Weight="8 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#5 in Books", CustomerReview=(float)4.7},

                new Book{bookName="The Body Keeps the Score",bookType="Paperback",publishDate=DateTime.Parse("2019-09-01"),Publisher="Penguin Books",Language="English",Paperback="440 pages"
                ,ISBN_10=1234567891,ISBN_13=1234567890123,Item_Weight="10 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#7 in Books", CustomerReview=(float)4.8},

                new Book{bookName="The Creative Act",bookType="Paperback",publishDate=DateTime.Parse("2006-09-01"),Publisher="Penguin Press",Language="English",Paperback="320 pages"
                ,ISBN_10=1234567891,ISBN_13=1234567890123,Item_Weight="8 Ounces",Dimensions="5.21 x 0.67 x 8.01 inches",
                    BestSellersRank="#9 in Books", CustomerReview=(float)4.7}

            };

            context.Books.AddRange(books);
            context.SaveChanges();

            var authors = new Author[]
            {
                new Author{authorName="James Clear",About="I’ve been writing at JamesClear.com about habits, decision making, and continuous improvement since 2012. I’m the author of the #1 New York Times bestseller, Atomic Habits, which has sold more than 15 million copies worldwide and has been translated into more than 50 languages. I’m also known for my popular 3-2-1 newsletter, which is sent out each week to more than 2 million subscribers."},
                  new Author{authorName="David Goggins", About="David Goggins is a Retired Navy SEAL and the only member of the U.S. Armed Forces to complete SEAL training, Army Ranger School, and Air Force Tactical Air Controller training."},
                    new Author{authorName="Mathhew Mcconaughey",About="Matthew McConaughey is a talented and versatile American actor known for his charismatic on-screen presence and memorable performances. With his laid-back charm and southern drawl, McConaughey has captivated audiences in a wide range of films, from romantic comedies like \"How to Lose a Guy in 10 Days\" to dramatic masterpieces like \"Dallas Buyers Club,\" for which he won an Academy Award. Throughout his career, he has displayed a remarkable ability to portray complex characters with depth and authenticity, earning him widespread critical acclaim and a dedicated fan following. Off-screen, McConaughey is an avid philanthropist and author, further exemplifying his commitment to making a positive impact on the world."},
                      new Author{authorName="Miroslav Volf", About = "Miroslav Volf is a prominent Croatian-American theologian and scholar who has made significant contributions to the fields of theology, ethics, and interfaith dialogue. Known for his profound insights into issues of forgiveness, reconciliation, and religious pluralism, Volf's work often explores the intersection of faith and contemporary societal challenges. He is the author of numerous influential books, including \"Exclusion and Embrace\" and \"A Public Faith,\" and has served as a professor and director of the Yale Center for Faith and Culture. Through his writings and teachings, Volf continues to inspire meaningful conversations and promote understanding across cultural and religious boundaries."},
                          new Author{authorName="Peter Attia, MD", About = "Peter Attia, MD, is a prominent physician, researcher, and advocate for health optimization. Specializing in longevity and performance enhancement, Dr. Attia has dedicated his career to exploring the science of human health and well-being. With a background in surgery and oncology, he has developed a deep understanding of metabolic health, nutrition, and exercise physiology. Through his popular podcast \"The Peter Attia Drive\" and writings on his website, he shares evidence-based insights on topics such as fasting, ketosis, and personalized medicine, empowering individuals to make informed decisions about their health. Dr. Attia's relentless pursuit of knowledge and commitment to improving lives have earned him recognition as a leading voice in the field of human performance and longevity."},
                            new Author{authorName="Robert T.Kiyosaki", About = "Robert T. Kiyosaki is an influential entrepreneur, investor, and best-selling author known for his financial education philosophy. He is best recognized for his book \"Rich Dad Poor Dad,\" which challenges conventional beliefs about money and advocates for financial literacy and investing. Kiyosaki emphasizes the importance of financial education and asset-building as the key to achieving financial independence. Through his writings, seminars, and games, such as the \"Cashflow\" board game, he has inspired millions worldwide to take control of their financial destinies and adopt a mindset geared towards building wealth and achieving financial freedom. His teachings continue to have a profound impact on individuals seeking to improve their financial intelligence and create a secure financial future."},
                              new Author{authorName="Prince Harry", About = "Prince Harry, also known as The Duke of Sussex, is a member of the British royal family and the younger son of Prince Charles and Princess Diana. Born on September 15, 1984, Harry has served in the British Army and actively supported various charitable causes. He gained widespread media attention for his involvement in philanthropic work, particularly his focus on mental health awareness through the \"Heads Together\" campaign. In 2018, he married Meghan Markle, an American actress, and the couple became known for their progressive approach to royal duties and advocacy for social issues. Prince Harry's decision, along with Meghan, to step back from their royal roles and relocate to the United States garnered significant media attention and sparked discussions about the roles and responsibilities of members within the British monarchy."},
                                new Author{authorName="Robert Greene", About = "Robert Greene is a renowned author, speaker, and strategist known for his influential works on human behavior and power dynamics. Born on May 14, 1959, he has written several bestselling books, including \"The 48 Laws of Power,\" \"The Art of Seduction,\" \"The 33 Strategies of War,\" and \"The 50th Law\" (co-authored with rapper 50 Cent). Greene's writings draw on historical examples and psychological insights to offer practical advice on navigating complex social and professional environments. His books have gained a devoted following among readers seeking to understand human nature, social dynamics, and the art of achieving success and influence."},
                                  new Author{authorName="Bessel Van Der Kolk, MD", About = "\r\nBessel van der Kolk, MD, is a prominent psychiatrist and expert in the field of trauma and post-traumatic stress disorder (PTSD). Born on May 5, 1943, he is known for his groundbreaking research and innovative approaches to trauma treatment. As the founder of the Trauma Center in Boston and a professor at Boston University School of Medicine, Dr. van der Kolk has dedicated his career to understanding the effects of trauma on the brain and body and developing effective therapeutic interventions. He is the author of the acclaimed book \"The Body Keeps the Score,\" which has become a seminal work in the field of trauma psychology, shedding light on the profound impact of trauma on individuals and offering insights into healing and resilience. Through his work, Dr. van der Kolk has significantly contributed to advancing the understanding and treatment of trauma-related conditions, making a lasting impact on the mental health field.\r\n\r\n\r\n\r\n\r\n"},
                                      new Author{authorName="Rick Rubin", About = "Rick Rubin is a highly influential and celebrated music producer, record executive, and co-founder of Def Jam Recordings. Born on March 10, 1963, Rubin is renowned for his ability to work across various genres, producing iconic albums for numerous artists spanning rock, hip-hop, and pop. With a minimalist approach and a keen ear for innovative sounds, he has been instrumental in shaping the careers of artists such as Beastie Boys, Run-D.M.C., Johnny Cash, Red Hot Chili Peppers, and many others. His productions are often characterized by their raw authenticity and stripped-down arrangements, allowing the artist's talent to shine through. Throughout his prolific career, Rick Rubin has earned numerous accolades and Grammy Awards, cementing his status as one of the most influential figures in the music industry.\r\n\r\n\r\n\r\n\r\n"}
                 
            };

            context.Authors.AddRange(authors);
            context.SaveChanges();

            var productdetails = new ProductDetail[]
            {


                 new ProductDetail{bookID = books[0].bookID, authorID = authors[0].authorID , bookName = books[0].bookName, authorName = authors[0].authorName },
                 new ProductDetail{bookID = books[0].bookID, authorID = authors[1].authorID , bookName = books[0].bookName, authorName = authors[1].authorName },
                 new ProductDetail{bookID = books[1].bookID, authorID = authors[1].authorID , bookName = books[1].bookName, authorName = authors[1].authorName },
                 new ProductDetail{bookID = books[2].bookID, authorID = authors[2].authorID , bookName = books[2].bookName, authorName = authors[2].authorName },
                 new ProductDetail{bookID = books[3].bookID, authorID = authors[3].authorID , bookName = books[3].bookName, authorName = authors[3].authorName },
                 new ProductDetail{bookID = books[4].bookID, authorID = authors[4].authorID , bookName = books[4].bookName, authorName = authors[4].authorName },
                 new ProductDetail{bookID = books[5].bookID, authorID = authors[5].authorID , bookName = books[5].bookName, authorName = authors[5].authorName },
                 new ProductDetail{bookID = books[6].bookID, authorID = authors[6].authorID , bookName = books[6].bookName, authorName = authors[6].authorName },
                 new ProductDetail{bookID = books[7].bookID, authorID = authors[7].authorID , bookName = books[7].bookName, authorName = authors[7].authorName },
                 new ProductDetail{bookID = books[8].bookID, authorID = authors[8].authorID , bookName = books[8].bookName, authorName = authors[8].authorName },
                 new ProductDetail{bookID = books[9].bookID, authorID = authors[9].authorID , bookName = books[9].bookName, authorName = authors[9].authorName }
               //  new ProductDetail{bookID = books[10].bookID, authorID = authors[10].authorID , bookName = books[10].bookName, authorName = authors[10].authorName }
                
            };

            context.ProductDetails.AddRange(productdetails);
            context.SaveChanges();
        }
    }
}