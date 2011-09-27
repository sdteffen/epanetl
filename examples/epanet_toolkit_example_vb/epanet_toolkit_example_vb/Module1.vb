Module Module1

    ' TODO: Add remaining declarations and constants from epanet2.h
    Declare Sub ENopen Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal inpfile As String, ByVal reportfile As String, ByVal binaryresultfile As String)
    Declare Sub ENgetcount Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal type As Integer, ByRef count As Integer)
    Declare Sub ENgetnodevalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal timestep As Integer, ByVal type As Integer, ByRef value As Single)
    Declare Sub ENgetlinkvalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal timestep As Integer, ByVal type As Integer, ByRef value As Single)
    Declare Sub ENinitQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal timestemp As Integer)
    Declare Sub ENclose Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENcloseQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENopenQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENreport Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENrunQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef timestep As Integer)
    Declare Sub ENsolveH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENstepQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef timestep As Integer)
    Declare Sub ENsolveQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    
    ' Node parameters
    Public Const EN_ELEVATION = 0
    Public Const EN_BASEDEMAND = 1
    Public Const EN_PATTERN = 2
    Public Const EN_EMITTER = 3
    Public Const EN_INITQUAL = 4
    Public Const EN_SOURCEQUAL = 5
    Public Const EN_SOURCEPAT = 6
    Public Const EN_SOURCETYPE = 7
    Public Const EN_TANKLEVEL = 8
    Public Const EN_DEMAND = 9
    Public Const EN_HEAD = 10
    Public Const EN_PRESSURE = 11
    Public Const EN_QUALITY = 12
    Public Const EN_SOURCEMASS = 13
    Public Const EN_INITVOLUME = 14
    Public Const EN_MIXMODEL = 15
    Public Const EN_MIXZONEVOL = 16

    Public Const EN_TANKDIAM = 17
    Public Const EN_MINVOLUME = 18
    Public Const EN_VOLCURVE = 19
    Public Const EN_MINLEVEL = 20
    Public Const EN_MAXLEVEL = 21
    Public Const EN_MIXFRACTION = 22
    Public Const EN_TANK_KBULK = 23
    ' Link parameters
    Public Const EN_DIAMETER = 0
    Public Const EN_LENGTH = 1
    Public Const EN_ROUGHNESS = 2
    Public Const EN_MINORLOSS = 3
    Public Const EN_INITSTATUS = 4
    Public Const EN_INITSETTING = 5
    Public Const EN_KBULK = 6
    Public Const EN_KWALL = 7
    Public Const EN_FLOW = 8
    Public Const EN_VELOCITY = 9
    Public Const EN_HEADLOSS = 10
    Public Const EN_STATUS = 11
    Public Const EN_SETTING = 12
    Public Const EN_ENERGY = 13

    ' Time parameters
    Public Const EN_DURATION = 0
    Public Const EN_HYDSTEP = 1
    Public Const EN_QUALSTEP = 2
    Public Const EN_PATTERNSTEP = 3
    Public Const EN_PATTERNSTART = 4
    Public Const EN_REPORTSTEP = 5
    Public Const EN_REPORTSTART = 6
    Public Const EN_RULESTEP = 7
    Public Const EN_STATISTIC = 8
    Public Const EN_PERIODS = 9

    Public Const EN_NODECOUNT = 0
    Public Const EN_TANKCOUNT = 1
    Public Const EN_LINKCOUNT = 2
    Public Const EN_PATCOUNT = 3
    Public Const EN_CURVECOUNT = 4
    Public Const EN_CONTROLCOUNT = 5

    'Node types
    Public Const EN_JUNCTION = 0
    Public Const EN_RESERVOIR = 1
    Public Const EN_TANK = 2

    'Link types
    Public Const EN_CVPIPE = 0
    Public Const EN_PIPE = 1
    Public Const EN_PUMP = 2
    Public Const EN_PRV = 3
    Public Const EN_PSV = 4
    Public Const EN_PBV = 5
    Public Const EN_FCV = 6
    Public Const EN_TCV = 7
    Public Const EN_GPV = 8

    ' Quality analysis types
    Public Const EN_NONE = 0
    Public Const EN_CHEM = 1
    Public Const EN_AGE = 2
    Public Const EN_TRACE = 3

    ' Source quality types
    Public Const EN_CONCEN = 0
    Public Const EN_MASS = 1
    Public Const EN_SETPOINT = 2
    Public Const EN_FLOWPACED = 3

    ' Flow unit types
    Public Const EN_CFS = 0
    Public Const EN_GPM = 1
    Public Const EN_MGD = 2
    Public Const EN_IMGD = 3
    Public Const EN_AFD = 4
    Public Const EN_LPS = 5
    Public Const EN_LPM = 6
    Public Const EN_MLD = 7
    Public Const EN_CMH = 8
    Public Const EN_CMD = 9

    ' Mistc, options
    Public Const EN_TRIALS = 0
    Public Const EN_ACCURACY = 1
    Public Const EN_TOLERANCE = 2
    Public Const EN_EMITEXPON = 3
    Public Const EN_DEMANDMULT = 4

    ' Control types
    Public Const EN_LOWLEVEL = 0
    Public Const EN_HILEVEL = 1
    Public Const EN_TIMER = 2
    Public Const EN_TIMEOFDAY = 3

    'Time statistics types
    Public Const EN_AVERAGE = 1
    Public Const EN_MINIMUM = 2
    Public Const EN_MAXIMUM = 3
    Public Const EN_RANGE = 4

    ' Tank mixing models
    Public Const EN_MIX1 = 0
    Public Const EN_MIX2 = 1
    Public Const EN_FIFO = 2
    Public Const EN_LIFO = 3

    Public Const EN_NOSAVE = 0   ' Save-results-to-file flag
    Public Const EN_SAVE = 1

    Public Const EN_INITFLOW = 10   ' Re-initialize flows flag 

    Public Const EN_CONST_HP = 0   ' constant horsepower          
    Public Const EN_POWER_FUNC = 1 'power function
    Public Const EN_CUSTOM = 2  ' user-defined custom curve


    Sub Main()
        Dim num_nodes As Integer
        Dim num_links As Integer
        Dim t As Integer
        Dim tleft As Integer
        Dim value As Single

        Call ENopen("C:\tmp\epanet_toolkit_example_vb\Net1.inp", "", "")
        Call ENgetcount(EN_NODECOUNT, num_nodes)
        Call ENgetcount(EN_LINKCOUNT, num_links)
        ENsolveH()
        ENopenQ()
        ENinitQ(0)
        Do  
            ENrunQ(t)
            For i = 0 To num_nodes - 1 Step 1
                ENgetnodevalue(i, EN_QUALITY, value)
                Console.WriteLine(value)
                ENgetnodevalue(i, EN_PRESSURE, value)
                Console.WriteLine(value)
            Next
            For i = 0 To num_links - 1 Step 1
                ENgetlinkvalue(i, EN_FLOW, value)
                Console.WriteLine(value)
            Next
            ENstepQ(tleft)
        Loop Until (tleft = 0)
        ENcloseQ()
        ENsolveQ()
        ENreport()
        ENclose()
    End Sub

End Module
