# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).


## v1.10 - 26.03.26
### Fixed
- Communication stability update for long-running ModbusTCP operation.
- fixed output-word sizing (NoOW) and reconnect parameter handling
- switched to deterministic request/response parsing with MBAP length fix
- added resilient reconnect state machine with retry backoff
- prioritized cyclic output updates to avoid drive watchdog fault 391
- improved timeout handling, enforced minimum read timeout and process-data cap
- added stream desync recovery by draining leftover bytes after timeout/mismatch


## v1.017 - 02.03.23
### Added
- add retryconnection() for ReadmbThread when connected and connectionError are both true
- add cbEnableDrive = false when festoCMMT.Connected is false 


## v1.01 - 20.04.22
### Added
- Create Log File when
  - Malfunction active
  - Disconnected
  - Exit application
  - Log data for debugging - log.mrh
- Default modbusTimeOut = 1000 (Previously = 100)
- Default setReadTimeOut = 100 (Previously = 30)
- Remove retryconnection delay 5sec xxx
- 1 Thread for Cycle --> 2 Thread for Read and Write --> to enhance stability
- add MaxReadmbTime, MaxWritembTime, ActualReadmbTime, ActualWritembTime 

## v0.9 - 27.07.21
### Fixed
- Fix Stop when homing, add new string response in CmmtControl method, "Homing interrupted"

### Added
- New response in iCmmtStatus = 11203 for "Homing interrupted"
- New properties:
  - int SetReadTimeOut {Get, Set}, (ms) Default = 30ms, minimum 10ms, skip read data from cmmt when time out reached
  - int MaxReadTime {Get, Set}, (ms) to monitor maximum read time
  - int MaxCycleTime {Get, Set}, (ms) to monitor maximum cycle time
  - int CounterPass (Get, Set}, to count number of ActualReadTime that exceed SetReadTimeOut
  - int ActualReadTime {Get}, (ms) to monitor actual read time
  - int ActualCycleTime {Get}, (ms) to monitor actual cycle time


## v0.98 - 10.07.21
### Added
- counterPass = how many time data from cmmt does not received (time out)
- setReadTime = how long (in ms) to wait for incoming data from cmmt
- actualReadTime, actualCycleTime
- maxReadTime = record highest actual read time
- maxCycleTime = record actual cycle time
- Detect system time from request data to receive data: setReadTimeOut (default=30ms, min 10ms)
- Check myStream.DataAvailable in answerReadInputRegister, if actualReadTime > setReadTimeOut --> ignore
- Check myStream.DataAvailable in answerWriteHoldingRegister, if actualReadTime > setReadTimeOut --> ignore
- Additional passive functionality to disconnect when error 391 occurs --> lookfor "Disconnect391"
- Additional passive functionality to stop retry --> lookfor "NoRetry"


## v0.97 - 27.04.21
### Added
- Add functionality to acommodate new target --> [15303]

## v0.96 - 03.11.20
### Fixed
- Fix Bug with CMMT firmware version v18
- Write output bQuery[10] & bQuary[11]

## v0.95 - 03.06.20
### Fixed
- Fix Target position minus value low bit: -65535 must be ommitted

## v0.94 - 22.05.20
### Added
- Add function to change modbus timeout
- Modbus address: 40401, Default: 100 ms, adjustable: 0 to 10000 ms
- Write: FC6 offset: 400, Read: FC3 offset: 400
- Re-arrange variable get set

## v0.93 - 06.05.20
### Added
- Add bit access to POS_STW2 and POS_ZSTW2
- to enable/disable software & hardware limit switch

## v0.92 - 10.04.20
### Added
- Apply get set for transfering information


## v0.91 - 09.04.20
### Fixed
- Fix bug status in cmmtcontrol during during continue record position
- iRetryCounnection do not reset
- timeout = 0 --> no timeout
- homingtimeout = 0 --> no homing timeout
- iCMMTstatus for cmmtcontrol sequence indicator = cmd mode step seq, ex: 11201 --> cmd=1,mode=1,step=20,seq=1 

## v0.9 - 04.04.20
- Initial release
