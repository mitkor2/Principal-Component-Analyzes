from pylibftdi import Driver


def get_ftdi_device_list():
    """
    return a list of lines, each a colon-separated
    vendor:product:serial summary of detected devices
    """
    dev_list = []
    for device in Driver().list_devices():
        # list_devices returns bytes rather than strings
        device = map(lambda x: x.decode('latin1'), device)
        # device must always be this triple
        vendor, product, serial = device
        dev_list.append("%s:%s:%s" % (vendor, product, serial))
    return dev_list

if __name__ == '__main__':
    for device in get_ftdi_device_list():
        print(device)