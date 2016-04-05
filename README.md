# DeadLockSample
Generates a simple deadlock threading scenario used for testing purposes.  Written for .Net 4.6.1 and CoreCLR.


## Commands


Ensure that either the CLR or CoreCLR is installed, then run the following commands

### Initial Setup

```dnu restore```

### Execution
Once setup, to run the sample, use

```dnx run```

Please note that this will eat up all your memory available.

### Build

```dnu build```

## Use Case

Best used in testing environments where memory can be limited so the process caps out before it tries to eat all the memory in the machine.
