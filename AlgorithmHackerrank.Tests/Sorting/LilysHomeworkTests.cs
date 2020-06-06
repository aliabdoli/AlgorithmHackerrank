﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHackerrank.Sorting;
using FluentAssertions;
using Xunit;

namespace AlgorithmHackerrank.Tests.Sorting
{
    //start: 6:50 pm 08/05/2020
    public class LilysHomeworkTests
    {
        [Theory]
        [InlineData(0, 3L, 2L)]
        [InlineData(2, 2L, 5L, 3L, 1L)]
        [InlineData(2, 7L, 15L, 12L, 3L)]
        [InlineData(2, 3L, 4L, 2L, 5L, 1L)]
        public void When_valid_array_then_find_min_swap(int expected, params long[] input)
        {
            var algo = new LilysHomework();
            int result = algo.FindMinSwap(input);
            result.Should().Be(expected);
        }


        [Theory]
        [MemberData(nameof(Data))]
        public void Test_algo_with_big_data(int expected, params long[] input)
        {
            var algo = new LilysHomework();
            int result = algo.FindMinSwap(input);
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_create_index_hash()
        {
            //arrange
            var input = new long[] { 30, 20 };
            var algo = new LilysHomework();

            //act
            var result = algo.CreateValueIndexHash(input.ToList());

            //assert
            result.Should().BeEquivalentTo(new Dictionary<long, int>()
            {
                {30L,0}, {20L, 1}
            });

        }
        
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { 268, 656085744L,  592976686L,  3037922L,  82266352L,  17574000L,  344340000L,  8406892L,  591292449L,  569625472L,  899357375L,  251327440L,  301303036L,  281400020L,  77370228L,  15516426L,  82859300L,  88364436L,  39767760L,  148417500L,  306863056L,  10926174L,  118195200L,  310408774L,  309307894L,  200852782L,  82193280L,  424056750L,  249277128L,  180368880L,  477624006L,  86748948L,  7434336L,  48882310L,  112635040L,  6614541L,  503907132L,  598034610L,  160500171L,  70444416L,  72752680L,  271416096L,  30521205L,  529365648L,  399367584L,  129849984L,  263500556L,  76737948L,  464269640L,  613416088L,  162724716L,  163420800L,  720512988L,  1217212920L,  727647624L,  383190420L,  8350904L,  3456024L,  289141064L,  123384024L,  158867856L,  82005504L,  36225521L,  533012608L,  54370440L,  17671500L,  53627000L,  26597644L,  855638940L,  55343960L,  57828624L,  108025344L,  21431808L,  1182600L,  265643950L,  30054300L,  219553915L,  74203500L,  658061160L,  7502400L,  931691763L,  295769136L,  107345925L,  80109000L,  130922055L,  33544944L,  65280L,  452996453L,  301655430L,  7828912L,  425016000L,  297635898L,  26861016L,  739961600L,  928116L,  19645470L,  8691456L,  5123880L,  596100015L,  2735436L,  25596483L,  173620720L,  202797504L,  161748972L,  30122300L,  11082820L,  574006860L,  426732182L,  71136825L,  105659136L,  1808140278L,  450779280L,  286831620L,  104683008L,  938781480L,  175050736L,  255681692L,  67096152L,  119518575L,  15449840L,  25273458L,  165048960L,  5642130L,  85199958L,  354920488L,  446786340L,  131214816L,  41533296L,  25766518L,  90782304L,  59007600L,  700369740L,  122021794L,  56982366L,  238027920L,  434370816L,  223677580L,  72463156L,  355858300L,  144914616L,  145950L,  13822570L,  19914930L,  11072100L,  21450528L,  124958730L,  105156800L,  20843784L,  781192188L,  448358850L,  6139822L,  95694780L,  78713888L,  677177472L,  9963972L,  366432768L,  181113408L,  725292862L,  473528052L,  12864000L,  518355540L,  55832070L,  318508876L,  89963781L,  1796290329L,  844308846L,  428627693L,  276255100L,  123609720L,  440449488L,  27589680L,  426614166L,  110068200L,  408846096L,  620309228L,  186565236L,  49051552L,  561738897L,  650114105L,  32646556L,  7174400L,  275364045L,  945364797L,  3674160L,  66314292L,  11073770L,  14885370L,  245088324L,  669628848L,  33110250L,  971699976L,  324099072L,  259496060L,  492110802L,  52206516L,  508725376L,  1534995792L,  148078816L,  57993375L,  121071195L,  381960195L,  12496176L,  23728250L,  159836835L,  712982980L,  160098622L,  909675852L,  110400300L,  485423372L,  30637838L,  339925836L,  285371600L,  13618242L,  80809650L,  92375040L,  265612788L,  1151909241L,  234661320L,  16962144L,  213417000L,  269646860L,  1015650090L,  117439476L,  53164566L,  6946134L,  89506800L,  305469360L,  13406432L,  292353000L,  9969642L,  43982198L,  23887296L,  67730660L,  16384192L,  218824704L,  1082660306L,  1679473908L,  136336179L,  39265884L,  1077096020L,  464272368L,  87048192L,  56752487L,  156212388L,  360621525L,  8472816L,  17613600L,  62143172L,  82696127L,  79939536L,  155805468L,  159499963L,  262072360L,  39827904L,  179532360L,  2455040L,  327280740L,  148409340L,  73738980L,  3394872L,  3082560L,  225009981L,  188912256L,  179487784L,  340340L,  315171072L,  96680664L,  621206280L,  536379504L,  391714074L,  65055960L,  105570465L,  365721408L,  106712025L,  286764660L},
            };

    }
}
