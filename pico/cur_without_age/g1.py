from pico.cur.go import main

while True:
    try:
        main('emulator-5554')
    except Exception:
        continue

